using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceScrambler2
{
    internal static class Constants
    {
        // File Types
        internal const string CPPFileType = "cpp";
        internal const string HFileType = "h";
        internal const string HPPFileType = "hpp";

        // Styles
        internal const MetroFramework.MetroColorStyle DefaultStyle = MetroFramework.MetroColorStyle.Magenta;
        internal const MetroFramework.MetroThemeStyle DefaultTheme = MetroFramework.MetroThemeStyle.Dark;

        internal const MetroFramework.MetroColorStyle TealStyle = MetroFramework.MetroColorStyle.Blue;
        internal const MetroFramework.MetroThemeStyle LightTheme = MetroFramework.MetroThemeStyle.Light;

        internal static double NextDouble(this Random random, double minValue, double maxValue)
        {
            return random.NextDouble() * (maxValue - minValue) + minValue;
        }

        internal static string RandomString(this Random random, int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
