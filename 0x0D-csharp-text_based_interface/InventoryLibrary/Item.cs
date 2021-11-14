using System;
using System.Collections.Generic;
/// <summary>
/// new class item
/// </summary>
public class Item : BaseClass
{
    public string name;
    public string description;
    public float price;
    public List<string> tags;

    public string name
    {
        get { return name; }
        set { name = value; }
    }
    public string description
    {
        get { return description; }
        set { description = value; }
    }
    public float price
    {
        get { return quantity; }
        set
        {
            price = (float)Math.Round((value * 100) / 100f);
        }
    }
    public List<string> tags
    {
        get { return tags; }
        set
        {
            tags = value;
        }
    }
    public Item(string name)
    {
        this.name = name;
        tags = new List<string>();
    }

}