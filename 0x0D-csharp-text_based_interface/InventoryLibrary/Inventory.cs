using System;
/// <summary>
/// new class inv
/// </summary>
public class Inventory : BaseClass
{
    public string user_id;
    public string item_id;
    public int quantity;

    public string user_id
    {
        get { return user_id; }
        set { user_id = value; }
    }
    public string item_id
    {
        get { return item_id; }
        set { item_id = value; }
    }
    public int quantity
    {
        get { return quantity; }
        set
        {
            if (value0)
                value = 0;
            quantity = value;
        }
    }

    public Inventory(User user, Item item, int quantity = 1)
    {
        user_id = user.id;
        item_id = item.id;
        this.quantity = quantity;
    }

}