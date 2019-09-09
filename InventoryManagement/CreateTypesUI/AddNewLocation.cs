using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace InventoryManagement.CreateTypesUI
{
    /// <summary>
    /// The form for adding a new location to the database
    /// </summary>
    public partial class AddNewLocation : MetroForm
    {
        /// <summary>
        /// The name of the location to save
        /// </summary>
        public new string Location = string.Empty;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddNewLocation()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates and saves the name of the location in <see cref="Location"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItemButton_Click(object sender, EventArgs e)
        {
            var location = LocationTextBox.Text;
            if (string.IsNullOrEmpty(location))
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Location = location;
                Close();
            }
        }
    }
}