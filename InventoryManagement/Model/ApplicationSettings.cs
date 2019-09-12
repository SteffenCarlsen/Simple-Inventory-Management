using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement.Model
{
    /// <summary>
    /// Provides application settings for the user
    /// </summary>
    public class ApplicationSettings
    {    
        /// <summary>
        /// Boolean value indicating whether the application starts with windows or not
        /// </summary>
        public bool StartWithWindows { get; set; }

        /// <summary>
        /// Folder location of the database
        /// </summary>
        public string DatabaseDirectory { get; set; }

        /// <summary>
        /// Name of the database
        /// </summary>
        public string DatabaseName { get; set; }

        /// <summary>
        /// Whether the database should be backed up automatically
        /// </summary>
        public bool AutoBackup { get; set; }

        /// <summary>
        /// Location of the automatic backup
        /// </summary>
        public string AutoSaveLocation { get; set; }

        /// <summary>
        /// Whether the backup system overrides the old backup
        /// </summary>
        public bool OverrideBackups { get; set; }

        /// <summary>
        /// How often does the backup need to happen
        /// </summary>
        public TimeSpan BackupFrequency { get; set; }

        /// <summary>
        /// Initializes the settings with default values
        /// </summary>
        public void LoadDefaults()
        {
            StartWithWindows = false;
            DatabaseName = @"Database.db";
            DatabaseDirectory = Environment.CurrentDirectory;
            AutoBackup = false;
            AutoSaveLocation = string.Empty;
            OverrideBackups = false;
            BackupFrequency = TimeSpan.Zero;
        }

        /// <summary>
        /// Performs a shallowcopy of the settings object
        /// </summary>
        /// <returns></returns>
        public ApplicationSettings ShallowCopy()
        {
            return (ApplicationSettings)this.MemberwiseClone();
        }

        /// <summary>
        /// Saves the setting file to disk
        /// </summary>
        /// <returns></returns>
        public bool Save()
        {
            try
            {
                JsonObjectFileSaveLoad.WriteToJsonFile(Path.Combine(Environment.CurrentDirectory, @"AppSettings.json"), this);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Loads settings from file
        /// </summary>
        /// <returns></returns>
        public bool Load()
        {
            try
            {
                var settingsobj =
                    JsonObjectFileSaveLoad.ReadFromJsonFile<ApplicationSettings>(
                        Path.Combine(Environment.CurrentDirectory, @"AppSettings.json"));
                StartWithWindows = settingsobj.StartWithWindows;
                DatabaseDirectory = settingsobj.DatabaseDirectory;
                DatabaseName = settingsobj.DatabaseName;
                AutoBackup = settingsobj.AutoBackup;
                AutoSaveLocation = settingsobj.AutoSaveLocation;
                OverrideBackups = settingsobj.OverrideBackups;
                BackupFrequency = settingsobj.BackupFrequency;
                return true;
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("Ingen indstillinger fil fundet, indlæser standard indstillinger",
                    "Ingen indstillinger fundet", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoadDefaults();
                Save();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Constructor for application settings
        /// </summary>
        /// <param name="startWithWindows"></param>
        /// <param name="databaseDirectory"></param>
        /// <param name="databaseName"></param>
        /// <param name="autoBackup"></param>
        /// <param name="autoSaveLocation"></param>
        /// <param name="overrideBackups"></param>
        /// <param name="backupFrequency"></param>
        public ApplicationSettings(bool startWithWindows, string databaseDirectory, string databaseName,
            bool autoBackup, string autoSaveLocation, bool overrideBackups, TimeSpan backupFrequency)
        {
            StartWithWindows = startWithWindows;
            DatabaseDirectory = databaseDirectory ?? throw new ArgumentNullException(nameof(databaseDirectory));
            DatabaseName = databaseName ?? throw new ArgumentNullException(nameof(databaseName));
            AutoBackup = autoBackup;
            AutoSaveLocation = autoSaveLocation ?? throw new ArgumentNullException(nameof(autoSaveLocation));
            OverrideBackups = overrideBackups;
            BackupFrequency = backupFrequency;
        }
        /// <summary>
        /// Default constructor
        /// </summary>
        public ApplicationSettings()
        {

        }
    }
}