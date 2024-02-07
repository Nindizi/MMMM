using System;

namespace MMMM_Library.Defaults
{
    /// <summary>
    /// Default file location folders, and explicit settings.xml file location definition
    /// </summary>
    public class FilePathDefaults
    {
        public static string ScratchFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\MMMM\";
                //on my dev machine, this maps to C:\Users\Diesel\AppData\Roaming\MMMM\
            }
        }

        public static string SettingsFolder
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MMMM\";
                //on my dev machine, this maps to C:\ProgramData\MMMM\
            }
        }

        public static string DefaultSavePath
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\MMMM\";
                //on my dev machine, this maps to C:\Users\Diesel\Documents\MMMM\
            }
        }

        public static string SettingsFile
        {
            get
            {
                return Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + @"\MMMM\";
                //on my dev machine, this maps to C:\ProgramData\Sausa\Settings.xml
            }
        }

    }
}
