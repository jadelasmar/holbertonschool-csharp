using System;

namespace InventoryLibrary
{
    /// <summary>
    /// new class inv
    /// </summary>
    public class Inventory : BaseClass
    {

        /// <summary> user id </summary>
        public string user_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        /// <summary> item id </summary>        
        public string item_id
        {
            get { return item_id; }
            set { item_id = value; }
        }
        /// <summary> quantity in the inventory. </summary>
        public int quantity
        {
            get { return quantity; }
            set
            {
                if (value < 0)
                    value = 0;
                quantity = value;
            }
        }
        /// <summary>
        /// const
        /// </summary>
        /// <param name="user"></param>
        /// <param name="item"></param>
        /// <param name="quantity"></param>
        public Inventory(User user, Item item, int quantity = 1)
        {
            user_id = user.id;
            item_id = item.id;
            this.quantity = quantity;
        }

    }
}