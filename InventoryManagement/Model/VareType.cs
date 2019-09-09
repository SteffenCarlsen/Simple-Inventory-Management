namespace InventoryManagement.Model
{
    /// <summary>
    /// A storage object for the type of an item
    /// Used to easier keep track of the type as objects rather than individually stored strings in a collection
    /// </summary>
    public class VareType
    {
        /// <summary>
        /// Default constructor
        /// Required to exist by LiteDB
        /// </summary>
        public VareType()
        {
        }
        /// <summary>
        /// Main constructor for setting the location
        /// </summary>
        /// <param name="type"></param>
        public VareType(string type)
        {
            Type = type;
        }
        /// <summary>
        /// The actual type
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The database ID, set by LiteDB
        /// </summary>
        public int Id { get; set; }
    }
}