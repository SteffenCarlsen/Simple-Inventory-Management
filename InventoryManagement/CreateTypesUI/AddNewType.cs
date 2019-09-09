using System;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace InventoryManagement.CreateTypesUI
{
    /// <summary>
    /// The form for creating a new type
    /// </summary>
    public partial class AddNewType : MetroForm
    {
        /// <summary>
        /// The name of the type to save
        /// </summary>
        public string Type = string.Empty;

        /// <summary>
        /// Default constructor
        /// </summary>
        public AddNewType()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Validates and saves the name of the type in <see cref="Type"/>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItemButton_Click(object sender, EventArgs e)
        {
            var type = VareTypeTextBox.Text;
            if (string.IsNullOrEmpty(type))
            {
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Type = type;
                Close();
            }
        }
    }
}