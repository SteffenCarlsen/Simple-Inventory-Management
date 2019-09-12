using System;
using System.IO;
using System.Timers;
using System.Windows.Forms;
using InventoryManagement.CreateTypesUI;
using InventoryManagement.Model;
using InventoryManagement.Properties;
using LiteDB;
using MetroFramework.Forms;
using AutoUpdaterDotNET;
using Timer = System.Windows.Forms.Timer;
namespace InventoryManagement
{
    /// <summary>
    /// The main inventory form
    /// </summary>
    public partial class InventoryForm : MetroForm
    {
        /// <summary>
        /// The database instance
        /// </summary>
        private LiteDatabase _db;

        /// <summary>
        /// A global application settings instance
        /// </summary>
        public ApplicationSettings AppSettings = new ApplicationSettings();

        /// <summary>
        /// A timer for the autobackup system
        /// </summary>
        private readonly Timer _autoBackupTimer = new Timer();

        /// <summary>
        /// Default constructor starting the application and initializing the database
        /// </summary>
        public InventoryForm()
        {
            InitializeComponent();
            AppSettings.Load();
            _db = new LiteDatabase(Path.Combine(AppSettings.DatabaseDirectory, AppSettings.DatabaseName));
            _db.Shrink();
            StartOrStopTimer();
        }

        /// <summary>
        /// Checks for Autobackup and starts or stops the timer
        /// </summary>
        private void StartOrStopTimer()
        {
            if (AppSettings.AutoBackup)
            {
                if (AppSettings.BackupFrequency.Hours == 0 && AppSettings.BackupFrequency.Minutes == 0)
                {
                    MessageBox.Show("Invalid tidsindstillinger til autobackup!", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrWhiteSpace(AppSettings.AutoSaveLocation))
                {
                    MessageBox.Show("Invalid backup lokation til autobackup!", "Fejl!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                _autoBackupTimer.Interval = (1000 * 3600 * AppSettings.BackupFrequency.Hours) +
                                            (60000 * AppSettings.BackupFrequency.Minutes);
                _autoBackupTimer.Tick += AutoBackupTimerOnTick;
                _autoBackupTimer.Start();
                AutoBackuppictureBox.BackgroundImage = Resources.cloud_computing;
            }
            else
            {
                AutoBackuppictureBox.BackgroundImage = Resources.cloud_computing_off;
                _autoBackupTimer.Stop();
            }
        }

        /// <summary>
        /// Autobackup timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AutoBackupTimerOnTick(object sender, EventArgs e)
        {
            if (!AppSettings.AutoBackup)
            {
                _autoBackupTimer.Stop();
            }

            if (!Directory.Exists(AppSettings.AutoSaveLocation))
            {
                MessageBox.Show("Invalid backup lokation til autobackup!\nSkift backup lokation for at starte backup igen!", "Fejl under autosave!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _autoBackupTimer.Stop();
            }

            if (AppSettings.OverrideBackups)
            {
                var path = Path.Combine(AppSettings.AutoSaveLocation, AppSettings.DatabaseName + ".bak");
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                var currentDbPath = Path.Combine(AppSettings.DatabaseDirectory, AppSettings.DatabaseName);
                File.Copy(currentDbPath,path);
            }
            else
            {
                var path = Path.Combine(AppSettings.AutoSaveLocation, Path.GetFileNameWithoutExtension(AppSettings.DatabaseName) + "_" + DateTime.Now.ToString("dd_MM_yyyy_HH_mm_ss") + ".bak");
                var currentDbPath = Path.Combine(AppSettings.DatabaseDirectory, AppSettings.DatabaseName);
                File.Copy(currentDbPath, path);
            }

        }

        /// <summary>
        /// Loads the data from the database into the controls on the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InventoryForm_Load(object sender, EventArgs e)
        {
            UpdateInventory();
            UpdateLocationCombobox();
            UpdateTypeCombobox();
        }

        /// <summary>
        /// Creates the <see cref="AddNewLocation"/> form
        /// and allows the user to create a new location
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newLocationBtn_Click(object sender, EventArgs e)
        {
            var addNewLocation = new AddNewLocation();
            var res = addNewLocation.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Invalid lokation forsøgt oprettet");
            }

            var loc = new Location(addNewLocation.Location);
            var items = _db.GetCollection<Location>("loc");
            items.Insert(loc);
            UpdateLocationCombobox();
        }

        /// <summary>
        /// Deletes the selected location from the database and combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteLocationBtn_Click(object sender, EventArgs e)
        {
            var comboboxItems = _db.GetCollection<Location>("loc");
            comboboxItems.Delete(x => x.LocationString == locationComboBox.SelectedItem.ToString());
            UpdateLocationCombobox();
        }

        /// <summary>
        /// Creates the <see cref="AddNewType"/> form
        /// and allows the user to create a new type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newTypeBtn_Click(object sender, EventArgs e)
        {
            var addnewType = new AddNewType();
            var res = addnewType.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Invalid type forsøgt oprettet");
            }

            var type = new VareType(addnewType.Type);
            var items = _db.GetCollection<VareType>("type");
            items.Insert(type);
            UpdateTypeCombobox();
        }

        /// <summary>
        /// Deletes the selected type from the database and combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteTypeBtn_Click(object sender, EventArgs e)
        {
            var comboBoxType = _db.GetCollection<VareType>("type");
            comboBoxType.Delete(x => x.Type == itemTypeComboBox.SelectedItem.ToString());
            UpdateTypeCombobox();
        }


        /// <summary>
        /// Creates the <see cref="AddNewInventoryItem"/> form
        /// and allows the user to create a new <see cref="Equipment"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newInventoryItemBtn_Click(object sender, EventArgs e)
        {
            var addnewInv = new AddNewInventoryItem(_db);
            var res = addnewInv.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Invalid inventar forsøgt oprettet");
                return;
            }

            var eq = addnewInv._eq;
            var items = _db.GetCollection<Equipment>("eq");
            items.Insert(eq);
            addnewInv._eq = null;
            UpdateInventory();
        }

        /// <summary>
        /// Deletes the selected row from the inventory
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteInventoryItemBtn_Click(object sender, EventArgs e)
        {
            var rowInfo = Inventory.SelectedRows;
            var res = MessageBox.Show("Du er ved at slette " + rowInfo.Count + " rækker\nVil du fortsætte?",
                "Bekræftelsesdialog", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res == DialogResult.No) return;
            var items = _db.GetCollection<Equipment>("eq");
            foreach (DataGridViewRow dataGridViewRow in rowInfo)
            {
                var id = dataGridViewRow.Cells[0].Value;
                if (id == null) continue;
                items.Delete(x => x.ManuelId == (int) id);
            }

            UpdateInventory();
        }

        /// <summary>
        /// Creates the <see cref="AddNewInventoryItem"/> form to edit an existing <see cref="Equipment"/>.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editInventoryItemBtn_Click(object sender, EventArgs e)
        {
            //Get row and ensure only 1 row is selected
            var rowInfo = Inventory.SelectedRows;
            if (rowInfo.Count > 1)
            {
                MessageBox.Show("Du kan kun redigere en ad gangen!");
                return;
            }

            //Retrieve the ID
            var manuelId = rowInfo[0].Cells[0].Value;
            if (manuelId == null) return;

            //Retrieve equipment data from db
            var items = _db.GetCollection<Equipment>("eq");
            var equip = items.FindOne(x => x.ManuelId == (int) manuelId);

            //Create new edit form with data
            var addNewInv = new AddNewInventoryItem(_db, equip);

            //Create dialog for user
            var res = addNewInv.ShowDialog();
            if (res != DialogResult.OK)
            {
                MessageBox.Show("Invalid inventar forsøgt redigeret");
                return;
            }

            //Update or insert new equipment
            items.Upsert(addNewInv._eq);
            //reset equipment to null
            addNewInv._eq = null;
            //Update UI
            UpdateInventory();
        }


        /// <summary>
        /// Updates the location combobox with data
        /// </summary>
        private void UpdateLocationCombobox()
        {
            locationComboBox.Items.Clear();
            var comboboxItems = _db.GetCollection<Location>("loc").FindAll();

            foreach (var location in comboboxItems)
            {
                if (location.LocationString == null) continue;
                locationComboBox.Items.Add(location.LocationString);
            }

            if (locationComboBox.Items.Count == 0)
            {
                locationComboBox.Items.Add("Ingen lokationer tilføjet");
            }

            locationComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Updates the type combobox with data
        /// </summary>
        private void UpdateTypeCombobox()
        {
            itemTypeComboBox.Items.Clear();
            var comboboxItems = _db.GetCollection<VareType>("type").FindAll();
            foreach (var type in comboboxItems)
            {
                if (type.Type == null) continue;
                itemTypeComboBox.Items.Add(type.Type);
            }

            if (itemTypeComboBox.Items.Count == 0)
            {
                itemTypeComboBox.Items.Add("Ingen typer tilføjet");
            }

            itemTypeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Updates the inventory listview with data
        /// </summary>
        private void UpdateInventory(string query = "")
        {
            Inventory.Rows.Clear();
            var items = _db.GetCollection<Equipment>("eq").FindAll();
            if (string.IsNullOrWhiteSpace(query))
            {
                foreach (var equipment in items)
                {
                    Inventory.Rows.Add(equipment.ManuelId, equipment.Name, equipment.Type.Type,
                        equipment.Location.LocationString, equipment.BorrowTime.ToShortDateString(),
                        equipment.EquipmentAge.ToShortDateString(), equipment.Note);
                }
            }
            else
            {
                foreach (var equipment in items)
                {
                    if (equipment.ContainsQueryString(query))
                    {
                        Inventory.Rows.Add(equipment.ManuelId, equipment.Name, equipment.Type.Type,
                            equipment.Location.LocationString, equipment.BorrowTime.ToShortDateString(),
                            equipment.EquipmentAge.ToShortDateString(), equipment.Note);
                    }
                }
            }
            
           
            
        }

        /// <summary>
        /// Opens the settings menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void settingsPictureBox_Click(object sender, EventArgs e)
        {
            var oldSettingsInstance = AppSettings.ShallowCopy();
            var settings = new Settings(AppSettings);
            var result = settings.ShowDialog();

            //Settings were OK, no database changes!
            if (result == DialogResult.OK)
            {
                AppSettings = settings.LocalApplicationSettings;
                StartOrStopTimer();
                AppSettings.Save();
            }

            //Settings were ok, database need to migrate to new location!
            if (result == DialogResult.Retry)
            {
                AppSettings = settings.LocalApplicationSettings;

                var oldDb = Path.Combine(oldSettingsInstance.DatabaseDirectory, oldSettingsInstance.DatabaseName);
                var newDb = Path.Combine(AppSettings.DatabaseDirectory, AppSettings.DatabaseName);

                AppSettings.Save();

                if (!File.Exists(oldDb))
                {
                    MessageBox.Show("Gammel database kan ikke tilgåes lige nu, prøv igen!","Fejl!",MessageBoxButtons.OK);
                    return;
                }

                if (File.Exists(newDb))
                {
                    MessageBox.Show("Der findes allerede en database", "Fejl", MessageBoxButtons.OK);
                    return;
                }

                File.Copy(oldDb,newDb);

                if (File.Exists(newDb))
                {
                    _db = new LiteDatabase(newDb);
                }

                StartOrStopTimer();
            }
        }

        private void QueryTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateInventory(QueryTextBox.Text);
        }
    }
}