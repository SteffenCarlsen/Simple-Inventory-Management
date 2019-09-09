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
    /// Form for editing the settings of the inventory manager
    /// </summary>
    public partial class Settings : MetroForm
    {
        private ApplicationSettings _settings;
        /// <summary>
        /// Default constructor
        /// </summary>
        public Settings(ApplicationSettings settings)
        {
            InitializeComponent();
            databaseLocationTextBox.Text = settings.DatabaseDirectory;
            databaseNameTextBox.Text = settings.DatabaseName;
            startWithwindowsCheckBox.Checked = settings.StartWithWindows;
            automaticBackupCheckBox.Checked = settings.AutoBackup;
            backupPanel.Enabled = settings.AutoBackup;
            backupLocationTextBox.Text = settings.AutoSaveLocation;
            overrideOldBackupCheckBox.Checked = settings.OverrideBackups;
            _settings = settings;
            backupFrequenceCtrl.ShowUpDown = true;
        }
        /// <summary>
        /// Saves the settings and stores it in the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveSettingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void automaticBackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            backupPanel.Enabled = automaticBackupCheckBox.Checked;
        }

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
    }
}
