using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Collections;
using System.IO;
using System.Diagnostics;
using Medallion;

namespace SourceScrambler2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        // Vars
        MetroFramework.MetroColorStyle CurrentStyle = Constants.DefaultStyle;
        MetroFramework.MetroThemeStyle CurrentTheme = Constants.DefaultTheme;

        string[] Styles = {"Dark", "Light"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateStyle();

            foreach (string item in Styles)
                StyleColorComboBox.Items.Add(item);
            StyleColorComboBox.SelectedIndex = 0;
        }

        private void UpdateStyle()
        {
            // Form objects
            this.Style = CurrentStyle;
            this.Theme = CurrentTheme;

            // Input directory objects
            DirectoryInputLabel.Style = CurrentStyle;
            DirectoryInputLabel.Theme = CurrentTheme;
            DirectoryInTextBox.Style = CurrentStyle;
            DirectoryInTextBox.Theme = CurrentTheme;
            DirectoryInButton.Style = CurrentStyle;
            DirectoryInButton.Theme = CurrentTheme;
            OpenInDirectoryButton.Style = CurrentStyle;
            OpenInDirectoryButton.Theme = CurrentTheme;

            // Output directory objects
            DirectoryOutputLabel.Style = CurrentStyle;
            DirectoryOutputLabel.Theme = CurrentTheme;
            DirectoryOutTextBox.Style = CurrentStyle;
            DirectoryOutTextBox.Theme = CurrentTheme;
            DirectoryOutButton.Style = CurrentStyle;
            DirectoryOutButton.Theme = CurrentTheme;
            OpenOutDirectoryButton.Style = CurrentStyle;
            OpenOutDirectoryButton.Theme = CurrentTheme;

            // Options objects
            OptionsLabel.Style = CurrentStyle;
            OptionsLabel.Theme = CurrentTheme;
            ShowConsoleCheckBox.Style = CurrentStyle;
            ShowConsoleCheckBox.Theme = CurrentTheme;

            // Console objects
            ConsoleLabel.Style = CurrentStyle;
            ConsoleLabel.Theme = CurrentTheme;
            ConsoleBox.Style = CurrentStyle;
            ConsoleBox.Theme = CurrentTheme;

            // Color theme objects
            StyleColorLabel.Style = CurrentStyle;
            StyleColorLabel.Theme = CurrentTheme;
            StyleColorComboBox.Style = CurrentStyle;
            StyleColorComboBox.Theme = CurrentTheme;

            // Scramble Button
            ScrambleButton.Style = CurrentStyle;
            ScrambleButton.Theme = CurrentTheme;
        }

        private void DirectoryInButton_Click(object sender, EventArgs e)
        {
            if (InputDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                InputDirectoryDialog.Description = "Choose Source Folder";
                string sFileName = InputDirectoryDialog.SelectedPath;
                DirectoryInTextBox.Text = sFileName;
            }
            DirectoryInputLabel.Focus();
        }

        private void DirectoryOutButton_Click(object sender, EventArgs e)
        {
            if (OutputDirectoryDialog.ShowDialog() == DialogResult.OK)
            {
                OutputDirectoryDialog.Description = "Choose Output Folder";
                string sFolderName = OutputDirectoryDialog.SelectedPath;
                DirectoryOutTextBox.Text = sFolderName;
            }
            DirectoryInputLabel.Focus();
        }

        private void ShowConsole_CheckChanged(object sender, EventArgs e)
        {
            if (ShowConsoleCheckBox.Checked)
            {
                ConsoleBox.Visible = true;
                ConsoleLabel.Visible = true;
                DirectoryInputLabel.Focus();
            }
            else
            {
                ConsoleBox.Visible = false;
                ConsoleLabel.Visible = false;
                DirectoryInputLabel.Focus();
            }
        }

        private bool CheckPath(string @path)
        {
            if (Directory.Exists(@path))
                return true;
            else
                return false;
        }

        private void CustomMessageBox(string title, string msg, MessageBoxButtons messageBoxButtons, MessageBoxIcon messageBoxIcon)
        {
            MetroFramework.MetroMessageBox.Show(this, msg, title, messageBoxButtons, messageBoxIcon);
        }

        private void OpenInDirectoryButton_Click(object sender, EventArgs e)
        {
            string path = DirectoryInTextBox.Text;
            if (CheckPath(@path))
                Process.Start("explorer.exe", @path);
            else
            {
                CustomMessageBox("Can't Open Directory", "The directory \"" + DirectoryInTextBox.Text + "\" can't be found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DirectoryInputLabel.Focus();
            }
            //MetroFramework.MetroMessageBox.Show(this, "The directory \"" + DirectoryInTextBox.Text + "\" can't be found.", "Can't Open Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OpenOutDirectoryButton_Click(object sender, EventArgs e)
        {
            string path = DirectoryOutTextBox.Text;
            if (CheckPath(@path))
                Process.Start("explorer.exe", @path);
            else
            {
                CustomMessageBox("Can't Open Directory", "The directory \"" + DirectoryOutTextBox.Text + "\" can't be found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DirectoryInputLabel.Focus();
            }
        }

        private void StyleColorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cmb = (ComboBox)sender;
            int selectedIndex = cmb.SelectedIndex;
            
            if(selectedIndex == 1)
            {
                CurrentStyle = Constants.TealStyle;
                CurrentTheme = Constants.LightTheme;
                StyleColorComboBox.SelectedIndex = 1;
            }
            else
            {
                CurrentStyle = Constants.DefaultStyle;
                CurrentTheme = Constants.DefaultTheme;
                StyleColorComboBox.SelectedIndex = 0;
            }

            UpdateStyle();
            this.Refresh();
        }

        private void Log(string msg)
        {
            ConsoleBox.AppendText("> " + DateTime.Now.ToString("h:mm:ss tt") + " - " + msg + "\n");
        }


        private string[] ReadFileLines(string @file)
        {
            string[] contents = File.ReadAllLines(@file);
            return contents;
        }

        private string GetExtension(string file, List<string> ExtensionFolders)
        {
            // After loop is done
            // Get File Name from path.
            string fileName = file.Split('\\').Last();

            string MatchingExtension = fileName;

            foreach (string extension in ExtensionFolders)
            {
                if (extension.Contains(fileName))
                {
                    MatchingExtension = extension;
                }
            }

            return MatchingExtension;
        }


        private void ScrambleFile(string[] Files, List<string> ExtensionFolders, string FileType, string @pathOut)
        {

            int FileCount = Files.Length;

            if (FileType.ToLower().Equals("cpp"))
            {

                // Do .cpp files
                if (FileCount > 0)
                {
                    Log("Starting .CPP Scrambling");

                    // For each file in the category. (CPP Files)
                    foreach (string @file in Files)
                    {

                        string[] contents = ReadFileLines(@file); // Store all lines in file -> string[] contents
                        List<string> contentsCopy = SwapLines(contents); // contentsCopy becomes a version of 'contents' where the lines are swapped. Takes 'contents' as input to not iterate over itself when swapping lines.  
                        List<string> contentsCopy2 = SwapBlocks(contentsCopy); // contentsCopy2 becomes a version of 'contentsCopy' where blocks (sections) of lines are swapped in chunks. Takes contentsCopy instead of contents -
                                                                               // so that it does not replace what SwapLines does previously.
                        List<string> contentsCopy3 = AddJunkLines(contentsCopy2);


                        // TODO: Find a way to optimize this?

                        string MatchingExtension = GetExtension(@file, ExtensionFolders); // Find folder that match for the output directories.

                        WriteToFile(contentsCopy3, MatchingExtension, @pathOut); // Write the contents to the pathOut folder.

                        Log("File " + MatchingExtension + " has been scrambled.");
                    }
                }
            }

            if (FileType.ToLower().Equals("h"))
            {
                // Do .h files
                if (FileCount > 0)
                {
                    Log("Starting .H Scrambling");
                    // For each file in the category. (H Files)
                    foreach (string @file in Files)
                    {
                        // Get all lines of the file.
                        string[] contents = ReadFileLines(@file);
                        List<string> contentsCopy = SwapLines(contents);
                        List<string> contentsCopy2 = SwapBlocks(contentsCopy); // contentsCopy2 becomes a version of 'contentsCopy' where blocks (sections) of lines are swapped in chunks. Takes contentsCopy instead of contents -
                                                                              //so that it does not replace what SwapLines does previously.

                        string MatchingExtension = GetExtension(@file, ExtensionFolders); // Find folder that match for the output directories.

                        WriteToFile(contentsCopy, MatchingExtension, @pathOut); // Write the contents to the pathOut folder.

                        Log("File " + MatchingExtension + " has been scrambled.");

                    }
                }
            }

            if (FileType.ToLower().Equals("hpp"))
            {
                // Do .hpp files
                if (FileCount > 0)
                {
                    Log("Starting .HPP Scrambling");
                    // For each file in the category. (HPP Files)
                    foreach (string @file in Files)
                    {
                        // Get all lines of the file.
                        string[] contents = ReadFileLines(@file);
                        List<string> contentsCopy = SwapLines(contents);
                        List<string> contentsCopy2 = SwapBlocks(contentsCopy); // contentsCopy2 becomes a version of 'contentsCopy' where blocks (sections) of lines are swapped in chunks. Takes contentsCopy instead of contents -
                                                                              //so that it does not replace what SwapLines does previously.

                        string MatchingExtension = GetExtension(@file, ExtensionFolders);

                        WriteToFile(contentsCopy, MatchingExtension, @pathOut); // Write the contents to the pathOut folder.

                        Log("File " + MatchingExtension + " has been scrambled.");

                    }
                }
            }

        }

        private List<string> AddJunkLines(List<string> contents)
        {
            List<string> contentsCopy = new List<string>(contents);
            Random random = new Random();

            // Check each line in array.
            for (int i = 0; i < contents.Count; i++)
            {
                // Check for swaplines
                if (contents[i].Contains("[add_junk_block /]"))
                {
                    Log("found junk block");
                    Log("Random Float between 1 and 2: " + Math.Round(random.NextDouble(random.NextDouble(1.11, 23.42), random.NextDouble(23.45, 521.23)), random.Next(3,9)).ToString());
                    Log("Random String: " + random.RandomString(random.Next(5, 11)));

                    // Make Function Header
                    contentsCopy.Insert(i + 1, "void " + random.RandomString(random.Next(5, 11)) + random.Next(2222223, 999999898) + "(){");

                    for(int h = 0; h < random.Next(5, 12); h++)
                    {

                    }


                    // TODO: Randomize if statements, finish this.
                }
            }

            return contentsCopy;
        }

        private List<string> SwapBlocks(List<string> contents)
        {
            // Get all lines of the file.
            List<string> contentsCopy = new List<string>(contents);

            int latestSwapBlocks = -1;
            int latestStopSwapBlocks = -1; 
            List<int> startswapblocks = new List<int>();
            List<int> stopswapblocks = new List<int>();

            List<int> startblock = new List<int>();
            List<int> endblock = new List<int>();

            // Check each line in array.
            for (int i = 0; i < contents.Count; i++)
            {
                // Check for swaplines
                if (contents[i].Contains("[swap_blocks]"))
                {
                    if (!startswapblocks.Contains(i))
                    {
                        latestSwapBlocks = i;

                    }
                }
                // Check for end swaplines
                if (contents[i].Contains("[/swap_blocks]"))
                {
                    if (!stopswapblocks.Contains(i))
                    {
                        latestStopSwapBlocks = i;

                    }
                }
                // If both points have been found and if they have not already been used. (Markers)
                if (latestSwapBlocks != -1 && latestStopSwapBlocks != -1 && !startswapblocks.Contains(latestSwapBlocks) && !stopswapblocks.Contains(latestSwapBlocks))
                {
                    // Check if waiting for next endpoint (presumably after first swap_lines pass)
                    if (latestStopSwapBlocks < latestSwapBlocks)
                        continue;

                    // Add the latest swapblocks so we dont reuse the same markers.
                    startswapblocks.Add(latestSwapBlocks);
                    stopswapblocks.Add(latestStopSwapBlocks);

                    // Clear lists, this is solely for the purpose of multiple passes of swap_blocks. Otherwise the block count from the last pass will be additive.
                    startblock.Clear();
                    endblock.Clear();

                    // Get swapsection
                    List<string> SwapSection = contentsCopy.GetRange(latestSwapBlocks + 1, latestStopSwapBlocks - latestSwapBlocks);
                    // Remove original
                    contentsCopy.RemoveRange(latestSwapBlocks + 1, latestStopSwapBlocks - latestSwapBlocks - 1);

                    // Get block markers
                    for (int l = 0; l < SwapSection.Count; l++)
                    {
                        if (SwapSection.ElementAt(l).ToLower().Contains("[block]"))
                        {
                            startblock.Add(l);
                        }

                        if (SwapSection.ElementAt(l).ToLower().Contains("[/block]"))
                        {
                            endblock.Add(l);
                        }
                    }


                    // Initialize lists for future use
                    List<List<string>> Blocks = new List<List<string>>();

                    // Get block contents and add blocks to 
                    for(int start = 0; start < startblock.Count; start++)
                    {
                        if (startblock.Count <= endblock.Count)               // Fairly certain something in here is wrong
                        {
                            List<string> BlockSection = SwapSection.GetRange(startblock.ElementAt(start), (endblock.ElementAt(start) - startblock.ElementAt(start)) + 1);
                            Blocks.Add(BlockSection);
                             
                        }
                    }

                    // Randomize list of blocks
                    Blocks.Shuffle();
                    Blocks.Shuffle();
                    Blocks.Shuffle();

                    // Insert Blocks back into file.

                    int LineCount = 1;
                    foreach(List<string> block in Blocks) // Loop through each block in Blocks
                    {
                        foreach(string line in block) // Loop through each line in block
                        {
                            contentsCopy.Insert(latestSwapBlocks + LineCount, line); // Insert the line of a block
                            LineCount++; // Add a counter so we know where to insert the next line. This is to save the position of the previous block.
                        }
                    }
                    
                    LineCount = 1; // Reset linecount for a possible next pass.

                    //++ Strategy for swapping blocks: 
                    //+                      done - Copy section of lines between markers into List. (the whole swap_blocks section)
                    //+                      done - Remove section between markers to clear "old" lines from original array
                    //+                      done - Determine markers of Blocks
                    //+                      done - Grab sections of lines between Block statements, after determining block sections
                    //+                      done - Place those lines into a List<List<string>> (list of contents in Block, in a list of Blocks)
                    //+                      done - Randomize the top List to reorder the Blocks
                    //+                      done - Insert Blocks back into file


                }

            }
            // Return the changed file.
            return contentsCopy;
        }

        private List<string> SwapLines(string[] contents)
        {
            // Get all lines of the file.
            List<string> contentsCopy = new List<string>(contents);

            int latestSwapLines = -1; //5  /15                                      //swap 5
            int latestStopSwapLines = -1; //10                                      //swapstop 10
                                          //swap 15

            List<int> startswaplines = new List<int>();
            List<int> stopswaplines = new List<int>();

            // Check each line in array.
            for (int i = 0; i < contents.Length; i++)
            {
                // Check for swaplines
                if (contents[i].Contains("[swap_lines]"))
                {
                    if (!startswaplines.Contains(i))
                    {
                        latestSwapLines = i;

                    }
                }
                // Check for end swaplines
                if (contents[i].Contains("[/swap_lines]"))
                {
                    if (!stopswaplines.Contains(i))
                    {
                        latestStopSwapLines = i;

                    }
                }
                // If both points have been found and if they have not already been used.
                if (latestSwapLines != -1 && latestStopSwapLines != -1 && !startswaplines.Contains(latestSwapLines) && !stopswaplines.Contains(latestStopSwapLines))
                {
                    startswaplines.Add(latestSwapLines);
                    stopswaplines.Add(latestStopSwapLines);
                    // Check if waiting for next endpoint (presumably after first swap_lines pass)
                    if (latestStopSwapLines < latestSwapLines)
                        continue;

                    // Get contents to shuffle and shuffle them.
                    List<string> swaplines = contents.Skip(latestSwapLines + 1).Take(latestStopSwapLines - latestSwapLines - 1).ToList();
                    swaplines.Shuffle();

                    // Remove elements from copy.
                    contentsCopy.RemoveRange(latestSwapLines + 1, latestStopSwapLines - latestSwapLines - 1);

                    // Insert shuffled elements back in to copy.
                    foreach (string line in swaplines)
                        contentsCopy.Insert(latestSwapLines + 1, line);

                }

            }
            // Return the changed file.
            return contentsCopy;
        }

        private void WriteToFile(List<string> contentsCopy, string FileName, string path)
        {
            if (FileName.Contains("\\"))
            {
                string NameOfFile = FileName.Split('\\').Last();
                DirectoryInfo di = Directory.CreateDirectory(path + (FileName.Substring(0, (FileName.Length - NameOfFile.Length))));
            }

            // new streamwriter to write to the output folder and create a file with the same name.
            TextWriter tw = new StreamWriter(path + "\\" + FileName, false);
            // foreach through the array to copy them to the file.
            foreach (string s in contentsCopy)
                tw.WriteLine(s);
            // close the file.
            tw.Close();
        }

        private string LogSeparator()
        {
            return "---------------------------------------------------------------------------------";
        }

        private List<string> GetExtensionFolders(string[] files, string pathIn)
        {
            List<string> folders = new List<string>();
            foreach (string @path in files)
            {
                string s = path.Substring(pathIn.Length);
                folders.Add(s);
            }
            return folders;
        }

        private void ScrambleButton_Click(object sender, EventArgs e)
        {
            DirectoryInputLabel.Focus();
            // Log start and get the set paths for the files.
            Log("Scrambler Started");
            string pathIn = DirectoryInTextBox.Text;
            string pathOut = DirectoryOutTextBox.Text;

            // Check for directories
            if (CheckPath(@pathIn) && CheckPath(@pathOut))
                if (@pathIn != @pathOut)
                    Log("Scrambler Directory Check - Passed");
                else
                {
                    CustomMessageBox("Directory Error", "Input and Output directories are the same.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Log("Scrambler Directory Check - Failed");
                    return;
                }
            else
            {
                CustomMessageBox("Can't Open Directory", "A directory can't be found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log("Scrambler Directory Check - Failed");
                Log("Scrambler Finished");
                return;
            }

            // Get all source files to be scrambled.
            string[] headerfiles = System.IO.Directory.GetFiles(@pathIn, "*.h", System.IO.SearchOption.AllDirectories);
            string[] header2files = System.IO.Directory.GetFiles(@pathIn, "*.hpp", System.IO.SearchOption.AllDirectories);
            string[] sourcefiles = System.IO.Directory.GetFiles(@pathIn, "*.cpp", System.IO.SearchOption.AllDirectories);

            List<string> SourceExtensionFolders = GetExtensionFolders(sourcefiles, pathIn);
            List<string> HeaderExtensionFolders = GetExtensionFolders(headerfiles, pathIn);
            List<string> Header2ExtensionFolders = GetExtensionFolders(header2files, pathIn);

            // Count files for totals.
            int HeaderCount = headerfiles.Length;
            int HeaderPPCount = header2files.Length;
            int CPPCount = sourcefiles.Length;
            int TotalFiles = HeaderCount + HeaderPPCount + CPPCount;

            // Log the output of ^
            Log("Obtained Directory Files");
            Log("Total Files: " + TotalFiles.ToString());
            Log(".cpp Files: " + CPPCount.ToString());
            Log(".h Files: " + HeaderCount.ToString());
            Log(".hpp Files: " + HeaderPPCount.ToString());

            if (TotalFiles == 0)
            {
                Log("Scrambler Finished - Completed Scrambling of " + TotalFiles.ToString() + " files.");
                return;
            }

            var watch = System.Diagnostics.Stopwatch.StartNew();

            // Scramble CPP Files
            ScrambleFile(sourcefiles, SourceExtensionFolders, Constants.CPPFileType, @pathOut);

            // Scramble H Files
            ScrambleFile(headerfiles, HeaderExtensionFolders, Constants.HFileType, @pathOut);

            // Scramble HPP Files
            ScrambleFile(header2files, Header2ExtensionFolders, Constants.HPPFileType, @pathOut);

            watch.Stop();
            Log("Scrambled " + TotalFiles.ToString() + " files in " + watch.ElapsedMilliseconds.ToString() + " milliseconds.");
            Log(LogSeparator());


        }


    }
}

