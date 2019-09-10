namespace InventoryManagement
{
    partial class InventoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventoryForm));
            this.Inventory = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IssueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.deleteLocationBtn = new MetroFramework.Controls.MetroButton();
            this.newLocationBtn = new MetroFramework.Controls.MetroButton();
            this.locationComboBox = new MetroFramework.Controls.MetroComboBox();
            this.locationLabel = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.newInventoryItemBtn = new MetroFramework.Controls.MetroButton();
            this.deleteInventoryItemBtn = new MetroFramework.Controls.MetroButton();
            this.editInventoryItemBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.deleteTypeBtn = new MetroFramework.Controls.MetroButton();
            this.newTypeBtn = new MetroFramework.Controls.MetroButton();
            this.itemTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.AutoBackuppictureBox = new System.Windows.Forms.PictureBox();
            this.settingsPictureBox = new System.Windows.Forms.PictureBox();
            this.QueryTextBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBackuppictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Inventory
            // 
            this.Inventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inventory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NameField,
            this.TypeField,
            this.LocationField,
            this.IssueDate,
            this.EquipmentAge,
            this.Note});
            this.Inventory.Location = new System.Drawing.Point(23, 63);
            this.Inventory.Name = "Inventory";
            this.Inventory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Inventory.Size = new System.Drawing.Size(860, 470);
            this.Inventory.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.Frozen = true;
            this.ID.HeaderText = "Udstyrs ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 75;
            // 
            // NameField
            // 
            this.NameField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NameField.HeaderText = "Vare navn";
            this.NameField.Name = "NameField";
            this.NameField.ReadOnly = true;
            this.NameField.Width = 75;
            // 
            // TypeField
            // 
            this.TypeField.HeaderText = "Type";
            this.TypeField.Name = "TypeField";
            // 
            // LocationField
            // 
            this.LocationField.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.LocationField.HeaderText = "Lokation";
            this.LocationField.Name = "LocationField";
            this.LocationField.ReadOnly = true;
            this.LocationField.Width = 73;
            // 
            // IssueDate
            // 
            this.IssueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.IssueDate.HeaderText = "Udstedelses dato";
            this.IssueDate.Name = "IssueDate";
            this.IssueDate.ReadOnly = true;
            this.IssueDate.Width = 105;
            // 
            // EquipmentAge
            // 
            this.EquipmentAge.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.EquipmentAge.HeaderText = "Vare alder";
            this.EquipmentAge.Name = "EquipmentAge";
            this.EquipmentAge.ReadOnly = true;
            this.EquipmentAge.Width = 74;
            // 
            // Note
            // 
            this.Note.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Note.HeaderText = "Ekstra note";
            this.Note.Name = "Note";
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.deleteLocationBtn);
            this.metroPanel1.Controls.Add(this.newLocationBtn);
            this.metroPanel1.Controls.Add(this.locationComboBox);
            this.metroPanel1.Controls.Add(this.locationLabel);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(889, 376);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(178, 157);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(147, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Tilgængelige lokationer";
            // 
            // deleteLocationBtn
            // 
            this.deleteLocationBtn.Location = new System.Drawing.Point(3, 124);
            this.deleteLocationBtn.Name = "deleteLocationBtn";
            this.deleteLocationBtn.Size = new System.Drawing.Size(168, 23);
            this.deleteLocationBtn.TabIndex = 5;
            this.deleteLocationBtn.Text = "Slet lokation";
            this.deleteLocationBtn.UseSelectable = true;
            this.deleteLocationBtn.Click += new System.EventHandler(this.deleteLocationBtn_Click);
            // 
            // newLocationBtn
            // 
            this.newLocationBtn.Location = new System.Drawing.Point(3, 95);
            this.newLocationBtn.Name = "newLocationBtn";
            this.newLocationBtn.Size = new System.Drawing.Size(168, 23);
            this.newLocationBtn.TabIndex = 4;
            this.newLocationBtn.Text = "Ny Lokation";
            this.newLocationBtn.UseSelectable = true;
            this.newLocationBtn.Click += new System.EventHandler(this.newLocationBtn_Click);
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.ItemHeight = 23;
            this.locationComboBox.Location = new System.Drawing.Point(3, 60);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(168, 29);
            this.locationComboBox.TabIndex = 3;
            this.locationComboBox.UseSelectable = true;
            // 
            // locationLabel
            // 
            this.locationLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.locationLabel.Location = new System.Drawing.Point(4, 6);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(167, 23);
            this.locationLabel.TabIndex = 2;
            this.locationLabel.Text = "Lokation indstillinger";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.newInventoryItemBtn);
            this.metroPanel2.Controls.Add(this.deleteInventoryItemBtn);
            this.metroPanel2.Controls.Add(this.editInventoryItemBtn);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(889, 63);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(178, 128);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // newInventoryItemBtn
            // 
            this.newInventoryItemBtn.Location = new System.Drawing.Point(3, 36);
            this.newInventoryItemBtn.Name = "newInventoryItemBtn";
            this.newInventoryItemBtn.Size = new System.Drawing.Size(168, 23);
            this.newInventoryItemBtn.TabIndex = 7;
            this.newInventoryItemBtn.Text = "Opret nyt inventar";
            this.newInventoryItemBtn.UseSelectable = true;
            this.newInventoryItemBtn.Click += new System.EventHandler(this.newInventoryItemBtn_Click);
            // 
            // deleteInventoryItemBtn
            // 
            this.deleteInventoryItemBtn.Location = new System.Drawing.Point(3, 94);
            this.deleteInventoryItemBtn.Name = "deleteInventoryItemBtn";
            this.deleteInventoryItemBtn.Size = new System.Drawing.Size(168, 23);
            this.deleteInventoryItemBtn.TabIndex = 5;
            this.deleteInventoryItemBtn.Text = "Slet valgt inventar";
            this.deleteInventoryItemBtn.UseSelectable = true;
            this.deleteInventoryItemBtn.Click += new System.EventHandler(this.deleteInventoryItemBtn_Click);
            // 
            // editInventoryItemBtn
            // 
            this.editInventoryItemBtn.Location = new System.Drawing.Point(3, 65);
            this.editInventoryItemBtn.Name = "editInventoryItemBtn";
            this.editInventoryItemBtn.Size = new System.Drawing.Size(168, 23);
            this.editInventoryItemBtn.TabIndex = 4;
            this.editInventoryItemBtn.Text = "Rediger valgt inventar";
            this.editInventoryItemBtn.UseSelectable = true;
            this.editInventoryItemBtn.Click += new System.EventHandler(this.editInventoryItemBtn_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(4, 6);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(167, 23);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Inventar indstillinger";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.deleteTypeBtn);
            this.metroPanel3.Controls.Add(this.newTypeBtn);
            this.metroPanel3.Controls.Add(this.itemTypeComboBox);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(889, 205);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(178, 157);
            this.metroPanel3.TabIndex = 7;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 38);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(148, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Tilgængelige vare typer";
            // 
            // deleteTypeBtn
            // 
            this.deleteTypeBtn.Location = new System.Drawing.Point(3, 124);
            this.deleteTypeBtn.Name = "deleteTypeBtn";
            this.deleteTypeBtn.Size = new System.Drawing.Size(168, 23);
            this.deleteTypeBtn.TabIndex = 5;
            this.deleteTypeBtn.Text = "Slet vare type";
            this.deleteTypeBtn.UseSelectable = true;
            this.deleteTypeBtn.Click += new System.EventHandler(this.deleteTypeBtn_Click);
            // 
            // newTypeBtn
            // 
            this.newTypeBtn.Location = new System.Drawing.Point(3, 95);
            this.newTypeBtn.Name = "newTypeBtn";
            this.newTypeBtn.Size = new System.Drawing.Size(168, 23);
            this.newTypeBtn.TabIndex = 4;
            this.newTypeBtn.Text = "Ny vare type";
            this.newTypeBtn.UseSelectable = true;
            this.newTypeBtn.Click += new System.EventHandler(this.newTypeBtn_Click);
            // 
            // itemTypeComboBox
            // 
            this.itemTypeComboBox.FormattingEnabled = true;
            this.itemTypeComboBox.ItemHeight = 23;
            this.itemTypeComboBox.Location = new System.Drawing.Point(3, 60);
            this.itemTypeComboBox.Name = "itemTypeComboBox";
            this.itemTypeComboBox.Size = new System.Drawing.Size(168, 29);
            this.itemTypeComboBox.TabIndex = 3;
            this.itemTypeComboBox.UseSelectable = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(4, 6);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(167, 23);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Vare type indstillinger";
            // 
            // AutoBackuppictureBox
            // 
            this.AutoBackuppictureBox.BackgroundImage = global::InventoryManagement.Properties.Resources.cloud_computing_off;
            this.AutoBackuppictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AutoBackuppictureBox.Location = new System.Drawing.Point(1015, 34);
            this.AutoBackuppictureBox.Name = "AutoBackuppictureBox";
            this.AutoBackuppictureBox.Size = new System.Drawing.Size(23, 23);
            this.AutoBackuppictureBox.TabIndex = 9;
            this.AutoBackuppictureBox.TabStop = false;
            // 
            // settingsPictureBox
            // 
            this.settingsPictureBox.BackgroundImage = global::InventoryManagement.Properties.Resources.settings;
            this.settingsPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settingsPictureBox.Location = new System.Drawing.Point(1044, 34);
            this.settingsPictureBox.Name = "settingsPictureBox";
            this.settingsPictureBox.Size = new System.Drawing.Size(23, 23);
            this.settingsPictureBox.TabIndex = 8;
            this.settingsPictureBox.TabStop = false;
            this.settingsPictureBox.Click += new System.EventHandler(this.settingsPictureBox_Click);
            // 
            // QueryTextBox
            // 
            // 
            // 
            // 
            this.QueryTextBox.CustomButton.Image = null;
            this.QueryTextBox.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.QueryTextBox.CustomButton.Name = "";
            this.QueryTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.QueryTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.QueryTextBox.CustomButton.TabIndex = 1;
            this.QueryTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.QueryTextBox.CustomButton.UseSelectable = true;
            this.QueryTextBox.CustomButton.Visible = false;
            this.QueryTextBox.Lines = new string[0];
            this.QueryTextBox.Location = new System.Drawing.Point(733, 34);
            this.QueryTextBox.MaxLength = 32767;
            this.QueryTextBox.Name = "QueryTextBox";
            this.QueryTextBox.PasswordChar = '\0';
            this.QueryTextBox.PromptText = "Søg her";
            this.QueryTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.QueryTextBox.SelectedText = "";
            this.QueryTextBox.SelectionLength = 0;
            this.QueryTextBox.SelectionStart = 0;
            this.QueryTextBox.ShortcutsEnabled = true;
            this.QueryTextBox.Size = new System.Drawing.Size(150, 23);
            this.QueryTextBox.TabIndex = 10;
            this.QueryTextBox.UseSelectable = true;
            this.QueryTextBox.WaterMark = "Søg her";
            this.QueryTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.QueryTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.QueryTextBox.TextChanged += new System.EventHandler(this.QueryTextBox_TextChanged);
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(1077, 552);
            this.Controls.Add(this.QueryTextBox);
            this.Controls.Add(this.AutoBackuppictureBox);
            this.Controls.Add(this.settingsPictureBox);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.Inventory);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "InventoryForm";
            this.Resizable = false;
            this.Text = "Inventar";
            this.Load += new System.EventHandler(this.InventoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Inventory)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoBackuppictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Inventory;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton deleteLocationBtn;
        private MetroFramework.Controls.MetroButton newLocationBtn;
        private MetroFramework.Controls.MetroComboBox locationComboBox;
        private MetroFramework.Controls.MetroLabel locationLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton newInventoryItemBtn;
        private MetroFramework.Controls.MetroButton deleteInventoryItemBtn;
        private MetroFramework.Controls.MetroButton editInventoryItemBtn;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton deleteTypeBtn;
        private MetroFramework.Controls.MetroButton newTypeBtn;
        private MetroFramework.Controls.MetroComboBox itemTypeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameField;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeField;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationField;
        private System.Windows.Forms.DataGridViewTextBoxColumn IssueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn Note;
        private System.Windows.Forms.PictureBox settingsPictureBox;
        private System.Windows.Forms.PictureBox AutoBackuppictureBox;
        private MetroFramework.Controls.MetroTextBox QueryTextBox;
    }
}

