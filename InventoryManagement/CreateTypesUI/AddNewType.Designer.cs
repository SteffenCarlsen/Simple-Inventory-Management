namespace InventoryManagement.CreateTypesUI
{
    partial class AddNewType
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewType));
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.saveItemButton = new MetroFramework.Controls.MetroButton();
            this.VareTypeTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel1);
            this.metroPanel3.Controls.Add(this.saveItemButton);
            this.metroPanel3.Controls.Add(this.VareTypeTextBox);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(23, 63);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(326, 74);
            this.metroPanel3.TabIndex = 10;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 19);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Vare type";
            // 
            // saveItemButton
            // 
            this.saveItemButton.Location = new System.Drawing.Point(3, 38);
            this.saveItemButton.Name = "saveItemButton";
            this.saveItemButton.Size = new System.Drawing.Size(318, 23);
            this.saveItemButton.TabIndex = 8;
            this.saveItemButton.Text = "Gem";
            this.saveItemButton.UseSelectable = true;
            this.saveItemButton.Click += new System.EventHandler(this.saveItemButton_Click);
            // 
            // VareTypeTextBox
            // 
            // 
            // 
            // 
            this.VareTypeTextBox.CustomButton.Image = null;
            this.VareTypeTextBox.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.VareTypeTextBox.CustomButton.Name = "";
            this.VareTypeTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.VareTypeTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.VareTypeTextBox.CustomButton.TabIndex = 1;
            this.VareTypeTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.VareTypeTextBox.CustomButton.UseSelectable = true;
            this.VareTypeTextBox.CustomButton.Visible = false;
            this.VareTypeTextBox.Lines = new string[0];
            this.VareTypeTextBox.Location = new System.Drawing.Point(153, 9);
            this.VareTypeTextBox.MaxLength = 32767;
            this.VareTypeTextBox.Name = "VareTypeTextBox";
            this.VareTypeTextBox.PasswordChar = '\0';
            this.VareTypeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VareTypeTextBox.SelectedText = "";
            this.VareTypeTextBox.SelectionLength = 0;
            this.VareTypeTextBox.SelectionStart = 0;
            this.VareTypeTextBox.ShortcutsEnabled = true;
            this.VareTypeTextBox.Size = new System.Drawing.Size(168, 23);
            this.VareTypeTextBox.TabIndex = 7;
            this.VareTypeTextBox.UseSelectable = true;
            this.VareTypeTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VareTypeTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // AddNewType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 155);
            this.Controls.Add(this.metroPanel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewType";
            this.Resizable = false;
            this.Text = "Tilføj ny vare type";
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton saveItemButton;
        private MetroFramework.Controls.MetroTextBox VareTypeTextBox;
    }
}