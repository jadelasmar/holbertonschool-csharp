using System;
using System.Collections.Generic;

namespace InventoryLibrary
{
    /// <summary>
    /// new class item
    /// </summary>
    public class Item : BaseClass
    {
        /// <summary> name of item </summary>
        public string name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary> optional: item desc </summary>
        public string description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary> A optional: item price </summary>
        public float price
        {
            get { return price; }
            set
            {
                price = (float)Math.Round((value * 100) / 100f);
            }
        }
        /// <summary>  optional: item tags </summary>
        public List<string> tags
        {
            get { return tags; }
            set
            {
                tags = value;
            }
        }
        /// <summary>
        /// const
        /// </summary>
        /// <param name="name"></param>
        /// <param name="description"></param>
        /// <param name="price"></param>
        /// <param name="tags"></param>
        public Item(string name, string description = null, float price = 0.00f, List<string> tags = null)
        {
            this.name = name;
            this.description = description;
            this.price = price;
            this.tags = tags;
        }

    }
}