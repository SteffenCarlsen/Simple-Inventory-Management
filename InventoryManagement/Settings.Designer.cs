namespace InventoryManagement
{
    partial class Settings
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
            this.saveSettingsBtn = new MetroFramework.Controls.MetroButton();
            this.databaseLocationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.databaseBrowseButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cancelSettingsButton = new MetroFramework.Controls.MetroButton();
            this.backupPanel = new MetroFramework.Controls.MetroPanel();
            this.hoursSelector = new System.Windows.Forms.NumericUpDown();
            this.minutesSelector = new System.Windows.Forms.NumericUpDown();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.overrideOldBackupCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.browseBackupLocButton = new MetroFramework.Controls.MetroButton();
            this.backupLocationTextBox = new MetroFramework.Controls.MetroTextBox();
            this.automaticBackupCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.databaseNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.startWithwindowsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.backupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSelector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // saveSettingsBtn
            // 
            this.saveSettingsBtn.Location = new System.Drawing.Point(23, 404);
            this.saveSettingsBtn.Name = "saveSettingsBtn";
            this.saveSettingsBtn.Size = new System.Drawing.Size(169, 23);
            this.saveSettingsBtn.TabIndex = 0;
            this.saveSettingsBtn.Text = "Gem indstillinger";
            this.saveSettingsBtn.UseSelectable = true;
            this.saveSettingsBtn.Click += new System.EventHandler(this.saveSettingsBtn_Click);
            // 
            // databaseLocationTextBox
            // 
            // 
            // 
            // 
            this.databaseLocationTextBox.CustomButton.Image = null;
            this.databaseLocationTextBox.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.databaseLocationTextBox.CustomButton.Name = "";
            this.databaseLocationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.databaseLocationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.databaseLocationTextBox.CustomButton.TabIndex = 1;
            this.databaseLocationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.databaseLocationTextBox.CustomButton.UseSelectable = true;
            this.databaseLocationTextBox.CustomButton.Visible = false;
            this.databaseLocationTextBox.Lines = new string[] {
        "metroTextBox1"};
            this.databaseLocationTextBox.Location = new System.Drawing.Point(142, 63);
            this.databaseLocationTextBox.MaxLength = 32767;
            this.databaseLocationTextBox.Name = "databaseLocationTextBox";
            this.databaseLocationTextBox.PasswordChar = '\0';
            this.databaseLocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.databaseLocationTextBox.SelectedText = "";
            this.databaseLocationTextBox.SelectionLength = 0;
            this.databaseLocationTextBox.SelectionStart = 0;
            this.databaseLocationTextBox.ShortcutsEnabled = true;
            this.databaseLocationTextBox.Size = new System.Drawing.Size(298, 23);
            this.databaseLocationTextBox.TabIndex = 1;
            this.databaseLocationTextBox.Text = "metroTextBox1";
            this.databaseLocationTextBox.UseSelectable = true;
            this.databaseLocationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.databaseLocationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // databaseBrowseButton
            // 
            this.databaseBrowseButton.Location = new System.Drawing.Point(446, 63);
            this.databaseBrowseButton.Name = "databaseBrowseButton";
            this.databaseBrowseButton.Size = new System.Drawing.Size(92, 23);
            this.databaseBrowseButton.TabIndex = 2;
            this.databaseBrowseButton.Text = "Vælg";
            this.databaseBrowseButton.UseSelectable = true;
            this.databaseBrowseButton.Click += new System.EventHandler(this.databaseBrowseButton_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 63);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(116, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Database lokation:";
            // 
            // cancelSettingsButton
            // 
            this.cancelSettingsButton.Location = new System.Drawing.Point(385, 404);
            this.cancelSettingsButton.Name = "cancelSettingsButton";
            this.cancelSettingsButton.Size = new System.Drawing.Size(169, 23);
            this.cancelSettingsButton.TabIndex = 4;
            this.cancelSettingsButton.Text = "Afslut uden at gemme";
            this.cancelSettingsButton.UseSelectable = true;
            this.cancelSettingsButton.Click += new System.EventHandler(this.cancelSettingsButton_Click);
            // 
            // backupPanel
            // 
            this.backupPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backupPanel.Controls.Add(this.metroLabel6);
            this.backupPanel.Controls.Add(this.metroLabel5);
            this.backupPanel.Controls.Add(this.hoursSelector);
            this.backupPanel.Controls.Add(this.minutesSelector);
            this.backupPanel.Controls.Add(this.metroLabel4);
            this.backupPanel.Controls.Add(this.overrideOldBackupCheckBox);
            this.backupPanel.Controls.Add(this.metroLabel2);
            this.backupPanel.Controls.Add(this.browseBackupLocButton);
            this.backupPanel.Controls.Add(this.backupLocationTextBox);
            this.backupPanel.Enabled = false;
            this.backupPanel.HorizontalScrollbarBarColor = true;
            this.backupPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.backupPanel.HorizontalScrollbarSize = 10;
            this.backupPanel.Location = new System.Drawing.Point(22, 225);
            this.backupPanel.Name = "backupPanel";
            this.backupPanel.Size = new System.Drawing.Size(531, 166);
            this.backupPanel.TabIndex = 5;
            this.backupPanel.VerticalScrollbarBarColor = true;
            this.backupPanel.VerticalScrollbarHighlightOnWheel = false;
            this.backupPanel.VerticalScrollbarSize = 10;
            // 
            // hoursSelector
            // 
            this.hoursSelector.Location = new System.Drawing.Point(255, 73);
            this.hoursSelector.Name = "hoursSelector";
            this.hoursSelector.Size = new System.Drawing.Size(92, 20);
            this.hoursSelector.TabIndex = 11;
            // 
            // minutesSelector
            // 
            this.minutesSelector.Location = new System.Drawing.Point(421, 75);
            this.minutesSelector.Name = "minutesSelector";
            this.minutesSelector.Size = new System.Drawing.Size(92, 20);
            this.minutesSelector.TabIndex = 10;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(7, 75);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(105, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = "Backup frekvens:";
            // 
            // overrideOldBackupCheckBox
            // 
            this.overrideOldBackupCheckBox.AutoSize = true;
            this.overrideOldBackupCheckBox.Location = new System.Drawing.Point(7, 39);
            this.overrideOldBackupCheckBox.Name = "overrideOldBackupCheckBox";
            this.overrideOldBackupCheckBox.Size = new System.Drawing.Size(161, 15);
            this.overrideOldBackupCheckBox.TabIndex = 7;
            this.overrideOldBackupCheckBox.Text = "Overskriv gammel backup";
            this.overrideOldBackupCheckBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(101, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Backup lokation";
            // 
            // browseBackupLocButton
            // 
            this.browseBackupLocButton.Location = new System.Drawing.Point(421, 10);
            this.browseBackupLocButton.Name = "browseBackupLocButton";
            this.browseBackupLocButton.Size = new System.Drawing.Size(92, 23);
            this.browseBackupLocButton.TabIndex = 5;
            this.browseBackupLocButton.Text = "Vælg";
            this.browseBackupLocButton.UseSelectable = true;
            this.browseBackupLocButton.Click += new System.EventHandler(this.browseBackupLocButton_Click);
            // 
            // backupLocationTextBox
            // 
            // 
            // 
            // 
            this.backupLocationTextBox.CustomButton.Image = null;
            this.backupLocationTextBox.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.backupLocationTextBox.CustomButton.Name = "";
            this.backupLocationTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.backupLocationTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.backupLocationTextBox.CustomButton.TabIndex = 1;
            this.backupLocationTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.backupLocationTextBox.CustomButton.UseSelectable = true;
            this.backupLocationTextBox.CustomButton.Visible = false;
            this.backupLocationTextBox.Lines = new string[] {
        "metroTextBox2"};
            this.backupLocationTextBox.Location = new System.Drawing.Point(118, 10);
            this.backupLocationTextBox.MaxLength = 32767;
            this.backupLocationTextBox.Name = "backupLocationTextBox";
            this.backupLocationTextBox.PasswordChar = '\0';
            this.backupLocationTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.backupLocationTextBox.SelectedText = "";
            this.backupLocationTextBox.SelectionLength = 0;
            this.backupLocationTextBox.SelectionStart = 0;
            this.backupLocationTextBox.ShortcutsEnabled = true;
            this.backupLocationTextBox.Size = new System.Drawing.Size(298, 23);
            this.backupLocationTextBox.TabIndex = 4;
            this.backupLocationTextBox.Text = "metroTextBox2";
            this.backupLocationTextBox.UseSelectable = true;
            this.backupLocationTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.backupLocationTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // automaticBackupCheckBox
            // 
            this.automaticBackupCheckBox.AutoSize = true;
            this.automaticBackupCheckBox.Location = new System.Drawing.Point(23, 204);
            this.automaticBackupCheckBox.Name = "automaticBackupCheckBox";
            this.automaticBackupCheckBox.Size = new System.Drawing.Size(217, 15);
            this.automaticBackupCheckBox.TabIndex = 6;
            this.automaticBackupCheckBox.Text = "Automatisk lokal backup af database";
            this.automaticBackupCheckBox.UseSelectable = true;
            this.automaticBackupCheckBox.CheckedChanged += new System.EventHandler(this.automaticBackupCheckBox_CheckedChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 92);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(97, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Database navn:";
            // 
            // databaseNameTextBox
            // 
            // 
            // 
            // 
            this.databaseNameTextBox.CustomButton.Image = null;
            this.databaseNameTextBox.CustomButton.Location = new System.Drawing.Point(276, 1);
            this.databaseNameTextBox.CustomButton.Name = "";
            this.databaseNameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.databaseNameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.databaseNameTextBox.CustomButton.TabIndex = 1;
            this.databaseNameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.databaseNameTextBox.CustomButton.UseSelectable = true;
            this.databaseNameTextBox.CustomButton.Visible = false;
            this.databaseNameTextBox.Lines = new string[] {
        "metroTextBox3"};
            this.databaseNameTextBox.Location = new System.Drawing.Point(142, 92);
            this.databaseNameTextBox.MaxLength = 32767;
            this.databaseNameTextBox.Name = "databaseNameTextBox";
            this.databaseNameTextBox.PasswordChar = '\0';
            this.databaseNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.databaseNameTextBox.SelectedText = "";
            this.databaseNameTextBox.SelectionLength = 0;
            this.databaseNameTextBox.SelectionStart = 0;
            this.databaseNameTextBox.ShortcutsEnabled = true;
            this.databaseNameTextBox.Size = new System.Drawing.Size(298, 23);
            this.databaseNameTextBox.TabIndex = 7;
            this.databaseNameTextBox.Text = "metroTextBox3";
            this.databaseNameTextBox.UseSelectable = true;
            this.databaseNameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.databaseNameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // startWithwindowsCheckBox
            // 
            this.startWithwindowsCheckBox.AutoSize = true;
            this.startWithwindowsCheckBox.Location = new System.Drawing.Point(23, 121);
            this.startWithwindowsCheckBox.Name = "startWithwindowsCheckBox";
            this.startWithwindowsCheckBox.Size = new System.Drawing.Size(379, 15);
            this.startWithwindowsCheckBox.TabIndex = 9;
            this.startWithwindowsCheckBox.Text = "Automatisk start med Windows (Kræver opstart som Administrator)";
            this.startWithwindowsCheckBox.UseSelectable = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(202, 74);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 12;
            this.metroLabel5.Text = "Timer:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(353, 74);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(62, 19);
            this.metroLabel6.TabIndex = 13;
            this.metroLabel6.Text = "Minutter:";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.startWithwindowsCheckBox);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.databaseNameTextBox);
            this.Controls.Add(this.automaticBackupCheckBox);
            this.Controls.Add(this.backupPanel);
            this.Controls.Add(this.cancelSettingsButton);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.databaseBrowseButton);
            this.Controls.Add(this.databaseLocationTextBox);
            this.Controls.Add(this.saveSettingsBtn);
            this.Name = "Settings";
            this.Text = "Indstillinger";
            this.backupPanel.ResumeLayout(false);
            this.backupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hoursSelector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutesSelector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton saveSettingsBtn;
        private MetroFramework.Controls.MetroTextBox databaseLocationTextBox;
        private MetroFramework.Controls.MetroButton databaseBrowseButton;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton cancelSettingsButton;
        private MetroFramework.Controls.MetroPanel backupPanel;
        private MetroFramework.Controls.MetroCheckBox overrideOldBackupCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton browseBackupLocButton;
        private MetroFramework.Controls.MetroTextBox backupLocationTextBox;
        private MetroFramework.Controls.MetroCheckBox automaticBackupCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox databaseNameTextBox;
        private MetroFramework.Controls.MetroCheckBox startWithwindowsCheckBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.NumericUpDown hoursSelector;
        private System.Windows.Forms.NumericUpDown minutesSelector;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
    }
}