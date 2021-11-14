using System;

namespace InventoryLibrary
{
    /// <summary>
    /// new class user
    /// </summary>
    public class User : BaseClass
    {
        /// <summary> user name </summary>
        public string name { get; set; }

        /// <summary>
        /// const
        /// </summary>
        /// <param name="name"></param>
        public User(string name)
        {
            this.name = name;
        }
    }
}