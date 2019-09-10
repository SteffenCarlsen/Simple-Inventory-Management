using System;

namespace InventoryManagement.Model
{
    /// <summary>
    /// Object for storing data about a type of equipment
    /// </summary>
    public class Equipment
    {
        /// <summary>
        /// Default constructor
        /// Required to exist by LiteDB
        /// </summary>
        public Equipment()
        {
        }

        /// <summary>
        /// Main constructor for setting all values
        /// </summary>
        /// <param name="manuelId"><see cref="ManuelId"/></param>
        /// <param name="name"><see cref="name"/></param>
        /// <param name="location"><see cref="location"/></param>
        /// <param name="type"><see cref="type"/></param>
        /// <param name="borrowTime"><see cref="borrowTime"/></param>
        /// <param name="equipmentAge"><see cref="equipmentAge"/></param>
        /// <param name="note"><see cref="note"/></param>
        public Equipment(int manuelId, string name, Location location, VareType type, DateTime borrowTime,
            DateTime equipmentAge, string note)
        {
            ManuelId = manuelId;
            Name = name;
            Location = location;
            BorrowTime = borrowTime;
            EquipmentAge = equipmentAge;
            Note = note;
            Type = type;
        }
        /// <summary>
        /// An id specified by the user to identify the item
        /// </summary>
        public int ManuelId { get; set; }
        /// <summary>
        /// The database ID, set by LiteDB
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the item
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The location of the item
        /// </summary>
        public Location Location { get; set; }
        /// <summary>
        /// The type of the item
        /// </summary>
        public VareType Type { get; set; }
        /// <summary>
        /// The time the item was last validated to be in the inventory
        /// </summary>
        public DateTime BorrowTime { get; set; }
        /// <summary>
        /// The DateTime of buying the item
        /// </summary>
        public DateTime EquipmentAge { get; set; }
        /// <summary>
        /// A note accompanying the item
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Returns if the specific equipment object contains a query string
        /// </summary>
        /// <param name="query">The query to search for</param>
        /// <returns></returns>
        public bool ContainsQueryString(string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return false;

            if (Note != null)
            {
                if (Note.ContainsInsensitive(query))
                {
                    return true;
                }
            }
            
            if (EquipmentAge != null)
            {
                if (EquipmentAge.ToString().ContainsInsensitive(query))
                {
                    return true;
                }
            }
            

            if (BorrowTime != null)
            {
                if (BorrowTime.ToString().ContainsInsensitive(query))
                {
                    return true;
                }
            }
            
            if (Type != null)
            {
                if (Type.Type.ContainsInsensitive(query))
                {
                    return true;
                }
            }

            if (Location != null)
            {
                if (Location.LocationString.ContainsInsensitive(query))
                {
                    return true;
                }
            }

            if (Name != null)
            {
                if (Name.ContainsInsensitive(query))
                {
                    return true;
                }
            }

            if (ManuelId != null)
            {
                if (ManuelId.ToString().ContainsInsensitive(query))
                {
                    return true;
                }
            }
            
            return false;
        }
    }
}