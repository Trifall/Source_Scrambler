namespace SourceScrambler2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DirectoryInTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DirectoryOutTextBox = new MetroFramework.Controls.MetroTextBox();
            this.DirectoryInputLabel = new MetroFramework.Controls.MetroLabel();
            this.DirectoryOutputLabel = new MetroFramework.Controls.MetroLabel();
            this.DirectoryInButton = new MetroFramework.Controls.MetroButton();
            this.InputDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.DirectoryOutButton = new MetroFramework.Controls.MetroButton();
            this.OutputDirectoryDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OptionsLabel = new MetroFramework.Controls.MetroLabel();
            this.ScrambleButton = new MetroFramework.Controls.MetroButton();
            this.ShowConsoleCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.ConsoleLabel = new MetroFramework.Controls.MetroLabel();
            this.ConsoleBox = new MetroFramework.Controls.MetroTextBox();
            this.OpenOutDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.OpenInDirectoryButton = new MetroFramework.Controls.MetroButton();
            this.StyleColorComboBox = new MetroFramework.Controls.MetroComboBox();
            this.StyleColorLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // DirectoryInTextBox
            // 
            // 
            // 
            // 
            this.DirectoryInTextBox.CustomButton.Image = null;
            this.DirectoryInTextBox.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.DirectoryInTextBox.CustomButton.Name = "";
            this.DirectoryInTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DirectoryInTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DirectoryInTextBox.CustomButton.TabIndex = 1;
            this.DirectoryInTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DirectoryInTextBox.CustomButton.UseSelectable = true;
            this.DirectoryInTextBox.CustomButton.Visible = false;
            this.DirectoryInTextBox.Lines = new string[0];
            this.DirectoryInTextBox.Location = new System.Drawing.Point(23, 121);
            this.DirectoryInTextBox.MaxLength = 32767;
            this.DirectoryInTextBox.Name = "DirectoryInTextBox";
            this.DirectoryInTextBox.PasswordChar = '\0';
            this.DirectoryInTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DirectoryInTextBox.SelectedText = "";
            this.DirectoryInTextBox.SelectionLength = 0;
            this.DirectoryInTextBox.SelectionStart = 0;
            this.DirectoryInTextBox.ShortcutsEnabled = true;
            this.DirectoryInTextBox.Size = new System.Drawing.Size(349, 23);
            this.DirectoryInTextBox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryInTextBox.TabIndex = 0;
            this.DirectoryInTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryInTextBox.UseSelectable = true;
            this.DirectoryInTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DirectoryInTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DirectoryOutTextBox
            // 
            // 
            // 
            // 
            this.DirectoryOutTextBox.CustomButton.Image = null;
            this.DirectoryOutTextBox.CustomButton.Location = new System.Drawing.Point(327, 1);
            this.DirectoryOutTextBox.CustomButton.Name = "";
            this.DirectoryOutTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.DirectoryOutTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.DirectoryOutTextBox.CustomButton.TabIndex = 1;
            this.DirectoryOutTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.DirectoryOutTextBox.CustomButton.UseSelectable = true;
            this.DirectoryOutTextBox.CustomButton.Visible = false;
            this.DirectoryOutTextBox.Lines = new string[0];
            this.DirectoryOutTextBox.Location = new System.Drawing.Point(23, 196);
            this.DirectoryOutTextBox.MaxLength = 32767;
            this.DirectoryOutTextBox.Name = "DirectoryOutTextBox";
            this.DirectoryOutTextBox.PasswordChar = '\0';
            this.DirectoryOutTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DirectoryOutTextBox.SelectedText = "";
            this.DirectoryOutTextBox.SelectionLength = 0;
            this.DirectoryOutTextBox.SelectionStart = 0;
            this.DirectoryOutTextBox.ShortcutsEnabled = true;
            this.DirectoryOutTextBox.Size = new System.Drawing.Size(349, 23);
            this.DirectoryOutTextBox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryOutTextBox.TabIndex = 1;
            this.DirectoryOutTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryOutTextBox.UseSelectable = true;
            this.DirectoryOutTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DirectoryOutTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // DirectoryInputLabel
            // 
            this.DirectoryInputLabel.AutoSize = true;
            this.DirectoryInputLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DirectoryInputLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DirectoryInputLabel.Location = new System.Drawing.Point(23, 93);
            this.DirectoryInputLabel.Name = "DirectoryInputLabel";
            this.DirectoryInputLabel.Size = new System.Drawing.Size(131, 25);
            this.DirectoryInputLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryInputLabel.TabIndex = 2;
            this.DirectoryInputLabel.Text = "Input Directory";
            this.DirectoryInputLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryInputLabel.UseStyleColors = true;
            // 
            // DirectoryOutputLabel
            // 
            this.DirectoryOutputLabel.AutoSize = true;
            this.DirectoryOutputLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.DirectoryOutputLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.DirectoryOutputLabel.Location = new System.Drawing.Point(23, 168);
            this.DirectoryOutputLabel.Name = "DirectoryOutputLabel";
            this.DirectoryOutputLabel.Size = new System.Drawing.Size(146, 25);
            this.DirectoryOutputLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryOutputLabel.TabIndex = 3;
            this.DirectoryOutputLabel.Text = "Output Directory";
            this.DirectoryOutputLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryOutputLabel.UseStyleColors = true;
            // 
            // DirectoryInButton
            // 
            this.DirectoryInButton.Location = new System.Drawing.Point(378, 121);
            this.DirectoryInButton.Name = "DirectoryInButton";
            this.DirectoryInButton.Size = new System.Drawing.Size(46, 23);
            this.DirectoryInButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryInButton.TabIndex = 4;
            this.DirectoryInButton.Text = "...";
            this.DirectoryInButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryInButton.UseSelectable = true;
            this.DirectoryInButton.UseStyleColors = true;
            this.DirectoryInButton.Click += new System.EventHandler(this.DirectoryInButton_Click);
            // 
            // DirectoryOutButton
            // 
            this.DirectoryOutButton.Location = new System.Drawing.Point(378, 196);
            this.DirectoryOutButton.Name = "DirectoryOutButton";
            this.DirectoryOutButton.Size = new System.Drawing.Size(46, 23);
            this.DirectoryOutButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.DirectoryOutButton.TabIndex = 5;
            this.DirectoryOutButton.Text = "...";
            this.DirectoryOutButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.DirectoryOutButton.UseSelectable = true;
            this.DirectoryOutButton.UseStyleColors = true;
            this.DirectoryOutButton.Click += new System.EventHandler(this.DirectoryOutButton_Click);
            // 
            // OptionsLabel
            // 
            this.OptionsLabel.AutoSize = true;
            this.OptionsLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.OptionsLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.OptionsLabel.Location = new System.Drawing.Point(23, 247);
            this.OptionsLabel.Name = "OptionsLabel";
            this.OptionsLabel.Size = new System.Drawing.Size(76, 25);
            this.OptionsLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.OptionsLabel.TabIndex = 6;
            this.OptionsLabel.Text = "Options";
            this.OptionsLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OptionsLabel.UseStyleColors = true;
            // 
            // ScrambleButton
            // 
            this.ScrambleButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.ScrambleButton.Location = new System.Drawing.Point(23, 519);
            this.ScrambleButton.Name = "ScrambleButton";
            this.ScrambleButton.Size = new System.Drawing.Size(178, 60);
            this.ScrambleButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ScrambleButton.TabIndex = 7;
            this.ScrambleButton.Text = "Scramble Source";
            this.ScrambleButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ScrambleButton.UseSelectable = true;
            this.ScrambleButton.UseStyleColors = true;
            this.ScrambleButton.Click += new System.EventHandler(this.ScrambleButton_Click);
            // 
            // ShowConsoleCheckBox
            // 
            this.ShowConsoleCheckBox.AutoSize = true;
            this.ShowConsoleCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.ShowConsoleCheckBox.Location = new System.Drawing.Point(35, 290);
            this.ShowConsoleCheckBox.Name = "ShowConsoleCheckBox";
            this.ShowConsoleCheckBox.Size = new System.Drawing.Size(111, 19);
            this.ShowConsoleCheckBox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ShowConsoleCheckBox.TabIndex = 8;
            this.ShowConsoleCheckBox.Text = "Show Console";
            this.ShowConsoleCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ShowConsoleCheckBox.UseSelectable = true;
            this.ShowConsoleCheckBox.UseStyleColors = true;
            this.ShowConsoleCheckBox.CheckedChanged += new System.EventHandler(this.ShowConsole_CheckChanged);
            // 
            // ConsoleLabel
            // 
            this.ConsoleLabel.AutoSize = true;
            this.ConsoleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ConsoleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ConsoleLabel.Location = new System.Drawing.Point(221, 231);
            this.ConsoleLabel.Name = "ConsoleLabel";
            this.ConsoleLabel.Size = new System.Drawing.Size(76, 25);
            this.ConsoleLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ConsoleLabel.TabIndex = 9;
            this.ConsoleLabel.Text = "Console";
            this.ConsoleLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConsoleLabel.UseStyleColors = true;
            this.ConsoleLabel.Visible = false;
            // 
            // ConsoleBox
            // 
            // 
            // 
            // 
            this.ConsoleBox.CustomButton.Image = null;
            this.ConsoleBox.CustomButton.Location = new System.Drawing.Point(188, 2);
            this.ConsoleBox.CustomButton.Name = "";
            this.ConsoleBox.CustomButton.Size = new System.Drawing.Size(315, 315);
            this.ConsoleBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ConsoleBox.CustomButton.TabIndex = 1;
            this.ConsoleBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ConsoleBox.CustomButton.UseSelectable = true;
            this.ConsoleBox.CustomButton.Visible = false;
            this.ConsoleBox.Lines = new string[0];
            this.ConsoleBox.Location = new System.Drawing.Point(221, 259);
            this.ConsoleBox.MaxLength = 50000;
            this.ConsoleBox.Multiline = true;
            this.ConsoleBox.Name = "ConsoleBox";
            this.ConsoleBox.PasswordChar = '\0';
            this.ConsoleBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ConsoleBox.SelectedText = "";
            this.ConsoleBox.SelectionLength = 0;
            this.ConsoleBox.SelectionStart = 0;
            this.ConsoleBox.ShortcutsEnabled = true;
            this.ConsoleBox.Size = new System.Drawing.Size(506, 320);
            this.ConsoleBox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.ConsoleBox.TabIndex = 10;
            this.ConsoleBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ConsoleBox.UseSelectable = true;
            this.ConsoleBox.UseStyleColors = true;
            this.ConsoleBox.Visible = false;
            this.ConsoleBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ConsoleBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OpenOutDirectoryButton
            // 
            this.OpenOutDirectoryButton.Location = new System.Drawing.Point(430, 196);
            this.OpenOutDirectoryButton.Name = "OpenOutDirectoryButton";
            this.OpenOutDirectoryButton.Size = new System.Drawing.Size(125, 23);
            this.OpenOutDirectoryButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.OpenOutDirectoryButton.TabIndex = 11;
            this.OpenOutDirectoryButton.Text = "Open Output Directory";
            this.OpenOutDirectoryButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenOutDirectoryButton.UseSelectable = true;
            this.OpenOutDirectoryButton.UseStyleColors = true;
            this.OpenOutDirectoryButton.Click += new System.EventHandler(this.OpenOutDirectoryButton_Click);
            // 
            // OpenInDirectoryButton
            // 
            this.OpenInDirectoryButton.Location = new System.Drawing.Point(430, 121);
            this.OpenInDirectoryButton.Name = "OpenInDirectoryButton";
            this.OpenInDirectoryButton.Size = new System.Drawing.Size(125, 23);
            this.OpenInDirectoryButton.Style = MetroFramework.MetroColorStyle.Magenta;
            this.OpenInDirectoryButton.TabIndex = 12;
            this.OpenInDirectoryButton.Text = "Open Input Directory";
            this.OpenInDirectoryButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.OpenInDirectoryButton.UseSelectable = true;
            this.OpenInDirectoryButton.UseStyleColors = true;
            this.OpenInDirectoryButton.Click += new System.EventHandler(this.OpenInDirectoryButton_Click);
            // 
            // StyleColorComboBox
            // 
            this.StyleColorComboBox.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.StyleColorComboBox.FormattingEnabled = true;
            this.StyleColorComboBox.ItemHeight = 19;
            this.StyleColorComboBox.Location = new System.Drawing.Point(617, 149);
            this.StyleColorComboBox.Name = "StyleColorComboBox";
            this.StyleColorComboBox.Size = new System.Drawing.Size(110, 25);
            this.StyleColorComboBox.Style = MetroFramework.MetroColorStyle.Magenta;
            this.StyleColorComboBox.TabIndex = 13;
            this.StyleColorComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StyleColorComboBox.UseSelectable = true;
            this.StyleColorComboBox.UseStyleColors = true;
            this.StyleColorComboBox.SelectedIndexChanged += new System.EventHandler(this.StyleColorComboBox_SelectedIndexChanged);
            // 
            // StyleColorLabel
            // 
            this.StyleColorLabel.AutoSize = true;
            this.StyleColorLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.StyleColorLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.StyleColorLabel.Location = new System.Drawing.Point(617, 121);
            this.StyleColorLabel.Name = "StyleColorLabel";
            this.StyleColorLabel.Size = new System.Drawing.Size(113, 25);
            this.StyleColorLabel.Style = MetroFramework.MetroColorStyle.Magenta;
            this.StyleColorLabel.TabIndex = 14;
            this.StyleColorLabel.Text = "Color Theme";
            this.StyleColorLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.StyleColorLabel.UseStyleColors = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.StyleColorLabel);
            this.Controls.Add(this.StyleColorComboBox);
            this.Controls.Add(this.OpenInDirectoryButton);
            this.Controls.Add(this.OpenOutDirectoryButton);
            this.Controls.Add(this.ConsoleBox);
            this.Controls.Add(this.ConsoleLabel);
            this.Controls.Add(this.ShowConsoleCheckBox);
            this.Controls.Add(this.ScrambleButton);
            this.Controls.Add(this.OptionsLabel);
            this.Controls.Add(this.DirectoryOutButton);
            this.Controls.Add(this.DirectoryInButton);
            this.Controls.Add(this.DirectoryOutputLabel);
            this.Controls.Add(this.DirectoryInputLabel);
            this.Controls.Add(this.DirectoryOutTextBox);
            this.Controls.Add(this.DirectoryInTextBox);
            this.Name = "Form1";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Magenta;
            this.Text = "Source Scrambler | Jerren T";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox DirectoryInTextBox;
        private MetroFramework.Controls.MetroTextBox DirectoryOutTextBox;
        private MetroFramework.Controls.MetroLabel DirectoryInputLabel;
        private MetroFramework.Controls.MetroLabel DirectoryOutputLabel;
        private MetroFramework.Controls.MetroButton DirectoryInButton;
        private System.Windows.Forms.FolderBrowserDialog InputDirectoryDialog;
        private MetroFramework.Controls.MetroButton DirectoryOutButton;
        private System.Windows.Forms.FolderBrowserDialog OutputDirectoryDialog;
        private MetroFramework.Controls.MetroLabel OptionsLabel;
        private MetroFramework.Controls.MetroButton ScrambleButton;
        private MetroFramework.Controls.MetroCheckBox ShowConsoleCheckBox;
        private MetroFramework.Controls.MetroLabel ConsoleLabel;
        private MetroFramework.Controls.MetroTextBox ConsoleBox;
        private MetroFramework.Controls.MetroButton OpenOutDirectoryButton;
        private MetroFramework.Controls.MetroButton OpenInDirectoryButton;
        private MetroFramework.Controls.MetroComboBox StyleColorComboBox;
        private MetroFramework.Controls.MetroLabel StyleColorLabel;
    }
}

