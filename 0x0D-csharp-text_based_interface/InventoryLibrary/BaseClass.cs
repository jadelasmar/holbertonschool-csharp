using System;

namespace InventoryLibrary
{
    /// <summary>
    /// BaseClas to inherit
    /// </summary>
    public class BaseClass
    {
        /// <summary> string of obj id. </summary>
        public string id { get; set; }
        /// <summary>time obj was created. </summary>
        public DateTime date_created { get; set; }
        /// <summary> time obj was updated. </summary>
        public DateTime date_updated { get; set; }

        /// <summary>
        /// const
        /// </summary>
        public BaseClass()
        {
            this.id = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Trim('=');
            this.date_created = DateTime.Now;
            this.date_updated = DateTime.Now;
        }
    }
}