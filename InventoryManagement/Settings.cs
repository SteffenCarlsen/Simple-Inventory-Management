using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagement.Model;
using MetroFramework.Forms;

namespace InventoryManagement
{
    /// <summary>
    /// Form for editing the ApplicationSettings of the inventory manager
    /// </summary>
    public partial class Settings : MetroForm
    {
        /// <summary>
        /// A local instance of localApplicationSettings to modify
        /// </summary>
        public ApplicationSettings LocalApplicationSettings;



        /// <summary>
        /// Default constructor
        /// </summary>
        public Settings(ApplicationSettings localApplicationSettings)
        {
            InitializeComponent();
            databaseLocationTextBox.Text = localApplicationSettings.DatabaseDirectory;
            databaseNameTextBox.Text = localApplicationSettings.DatabaseName;
            startWithwindowsCheckBox.Checked = localApplicationSettings.StartWithWindows;
            automaticBackupCheckBox.Checked = localApplicationSettings.AutoBackup;
            backupPanel.Enabled = localApplicationSettings.AutoBackup;
            backupLocationTextBox.Text = localApplicationSettings.AutoSaveLocation;
            overrideOldBackupCheckBox.Checked = localApplicationSettings.OverrideBackups;
            hoursSelector.Value = localApplicationSettings.BackupFrequency.Hours;
            minutesSelector.Value = localApplicationSettings.BackupFrequency.Minutes;
            LocalApplicationSettings = localApplicationSettings;
        }

        /// <summary>
        /// Saves the ApplicationSettings and stores it in the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {
            //Validate all data
            if (string.IsNullOrEmpty(databaseLocationTextBox.Text))
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Invalid database lokation", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(databaseNameTextBox.Text))
            {
                this.DialogResult = DialogResult.None;
                MessageBox.Show("Invalid database navn", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (automaticBackupCheckBox.Checked)
            {
                if (string.IsNullOrEmpty(backupLocationTextBox.Text))
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("Invalid backup database location", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (hoursSelector.Value == 0 && minutesSelector.Value == 0)
                {
                    this.DialogResult = DialogResult.None;
                    MessageBox.Show("Timer og minutter må ikke begge være 0!", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            DialogResult = !LocalApplicationSettings.DatabaseDirectory.Equals(databaseLocationTextBox.Text) ? DialogResult.Retry : DialogResult.OK;

            LocalApplicationSettings.DatabaseDirectory = databaseLocationTextBox.Text;
            LocalApplicationSettings.DatabaseName = databaseNameTextBox.Text;
            LocalApplicationSettings.StartWithWindows = startWithwindowsCheckBox.Checked;
            LocalApplicationSettings.AutoBackup = automaticBackupCheckBox.Checked;
            LocalApplicationSettings.BackupFrequency = new TimeSpan((int)hoursSelector.Value,(int)minutesSelector.Value,0);
            LocalApplicationSettings.AutoSaveLocation = backupLocationTextBox.Text;
            LocalApplicationSettings.OverrideBackups = overrideOldBackupCheckBox.Checked;

            if (LocalApplicationSettings.StartWithWindows)
            {
                if (!Startup.IsInStartup())
                {
                    Startup.RunOnStartup();
                }
            }
            else
            {
                if (Startup.IsInStartup())
                {
                    Startup.RemoveFromStartup();
                }
            }
        }

        /// <summary>
        /// Enables/Disables the backup panel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void automaticBackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            backupPanel.Enabled = automaticBackupCheckBox.Checked;
        }

        /// <summary>
        /// Opens a FolderBrowserDialog to select the database save location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void databaseBrowseButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var res = folderDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                databaseLocationTextBox.Text = folderDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Opens a FolderBrowserDialog to select the backup location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void browseBackupLocButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
            var res = folderDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                backupLocationTextBox.Text = folderDialog.SelectedPath;
            }
        }

        /// <summary>
        /// Closes the form without saving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelSettingsButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}