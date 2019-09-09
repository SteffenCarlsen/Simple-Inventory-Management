namespace InventoryManagement.Model
{
    /// <summary>
    /// A storage object for a location
    /// Used to easier keep track of locations as objects rather than individually stored strings in a collection
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Default constructor
        /// Required to exist by LiteDB
        /// </summary>
        public Location()
        {
        }

        /// <summary>
        /// Main constructor for setting the location
        /// </summary>
        /// <param name="location"></param>
        public Location(string location)
        {
            LocationString = location;
        }

        /// <summary>
        /// The location
        /// </summary>
        public string LocationString { get; set; }
        /// <summary>
        /// The database ID, set by LiteDB
        /// </summary>
        public int Id { get; set; }
    }
}