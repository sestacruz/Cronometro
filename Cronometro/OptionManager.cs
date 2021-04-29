using Cronometro.Properties;
using System.Drawing;

namespace Cronometro.Options
{
    public static class OptionManager 
    {
        public enum units : int { Decimal = 10, Sexagecimal = 60, Both = 160};
        public static int GetDisplayUnit()
        {
            return Settings.Default.displayUnit;
        }

        public static bool GetBackUp()
        {
            return Settings.Default.backUp;
        }

        public static int GetBackUpTime()
        {
            return Settings.Default.backUpTime;
        }

        public static bool GetPopUp()
        {
            return Settings.Default.popUp;
        }

        public static int GetPopUpTime()
        {
            return Settings.Default.popUpTime;
        }

        public static void SetDisplayUnit(int newValue)
        {
            Settings.Default.displayUnit = newValue;
            Settings.Default.Save();
        }
        public static void SetPopUp(bool newValue)
        {
            Settings.Default.popUp = newValue;
            Settings.Default.Save();
        }
        public static void SetPopUpTime(int newValue)
        {
            Settings.Default.popUpTime = newValue;
            Settings.Default.Save();
        }

        public static void SetBackUp(bool newValue)
        {
            Settings.Default.backUp = newValue;
            Settings.Default.Save();
        }
        public static void SetBackUpTime(int newValue)
        {
            Settings.Default.backUpTime = newValue;
            Settings.Default.Save();
        }

        public static Color GetDisplayColor()
        {
            return Settings.Default.displayColor;
        }

        public static void SetDisplayColor(Color newValue)
        {
            Settings.Default.displayColor = newValue;
            Settings.Default.Save();
        }
        public static string GetSeparator()
        {
            return Settings.Default.separator;
        }

        public static void SetSeparator(string newValue)
        {
            Settings.Default.separator = newValue;
            Settings.Default.Save();
        }
    }
}
