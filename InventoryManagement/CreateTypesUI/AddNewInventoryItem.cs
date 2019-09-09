using System;
using System.Windows.Forms;
using InventoryManagement.Model;
using LiteDB;
using MetroFramework.Forms;

namespace InventoryManagement.CreateTypesUI
{
    /// <summary>
    /// Form used for creating a new inventory item
    /// </summary>
    public partial class AddNewInventoryItem : MetroForm
    {
        private readonly LiteDatabase _db;
        public Equipment _eq;

        /// <summary>
        /// Constructor for creating a new <see cref="Equipment"/>
        /// </summary>
        /// <param name="db">the active database instance</param>
        public AddNewInventoryItem(LiteDatabase db)
        {
            InitializeComponent();
            _db = db;
            FormLoad();
        }

        /// <summary>
        /// Constructor for editing an existing <see cref="Equipment"/>
        /// </summary>
        /// <param name="db">the active database instance</param>
        /// <param name="equipment">The object to modify</param>
        public AddNewInventoryItem(LiteDatabase db, Equipment equipment)
        {
            InitializeComponent();
            _db = db;
            FormLoad();
            itemTypeComboBox.SelectedItem = equipment.Type.Type;
            LocationComboBox.SelectedItem = equipment.Location.LocationString;
            metroTextBox1.Text = equipment.ManuelId.ToString();
            metroTextBox2.Text = equipment.Name;
            IssueDateTime.Value = equipment.BorrowTime;
            AgeDateTime.Value = equipment.EquipmentAge;
            noteTextBox.Text = equipment.Note;
            _eq = equipment;
        }

        /// <summary>
        /// A universal loading method to call post constructor-call
        /// Created as OnFormLoad behaves differently than expected
        /// </summary>
        private void FormLoad()
        {
            var varer = _db.GetCollection<VareType>("type").FindAll();
            foreach (var type in varer)
            {
                if(type.Type == null)continue;
                itemTypeComboBox.Items.Add(type.Type);
            }

            var locations = _db.GetCollection<Location>("loc").FindAll();
            foreach (var location in locations)
            {
                if (location.LocationString == null) continue;
                LocationComboBox.Items.Add(location.LocationString);
            }
        }

        /// <summary>
        /// Saves the currently being edited Equipment item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveItemButton_Click(object sender, EventArgs e)
        {
            var id = metroTextBox1.Text;
            var success = int.TryParse(id, out var intId);
            if (!success)
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            var name = metroTextBox2.Text;
            if (string.IsNullOrWhiteSpace(name))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            var item = itemTypeComboBox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(item))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            var type = _db.GetCollection<VareType>("type").FindOne(x => x.Type == item);

            var locationString = LocationComboBox.SelectedItem.ToString();
            if (string.IsNullOrWhiteSpace(locationString))
            {
                DialogResult = DialogResult.Cancel;
                return;
            }

            var location = _db.GetCollection<Location>("loc").FindOne(x => x.LocationString == locationString);

            var issueDateTime = IssueDateTime.Value;
            var eqAge = AgeDateTime.Value;
            if (_eq == null)
            {
                _eq = new Equipment(intId, name, location, type, issueDateTime, eqAge, noteTextBox.Text);
            }
            else
            {
                _eq.Location = location;
                _eq.BorrowTime = issueDateTime;
                _eq.EquipmentAge = eqAge;
                _eq.Type = type;
                _eq.Name = name;
                _eq.ManuelId = intId;
                _eq.Note = noteTextBox.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}