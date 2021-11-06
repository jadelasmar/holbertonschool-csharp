using System;
/// <summary>
/// new abstrace Base
/// </summary>
public abstract class Base
{
    /// <summary>
    /// r
    /// </summary>
    /// <value></value>
    public string name
    {
        get;
        set;
    }
    /// <summary>
    /// override toString
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return name + " is a " + GetType().Name;
    }
}
/// <summary>
/// new interface IInteractive
/// </summary>
public interface IInteractive
{
    /// <summary>
    /// Interact with this object.
    /// </summary>
    void Interact();
}
/// <summary>
/// new interface IBreakable
/// </summary>
public interface IBreakable
{
    /// <summary>
    /// durability of object
    /// </summary>
    /// <value></value>
    int durability { get; set; }
    /// <summary>
    /// break
    /// </summary>
    void Break();
}

/// <summary>
/// new interface ICollectable
/// </summary>
public interface ICollectable
{
    /// <summary>
    /// is collected ?
    /// </summary>
    /// <value></value>
    bool isCollected { get; set; }
    /// <summary>
    /// collect
    /// </summary>
    void Collect();
}

/// <summary>
/// class door
/// </summary>
public class Door : Base, IInteractive
{
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="name"></param>
    public Door(string name = "Door")
    {
        this.name = name;
    }
    /// <summary>
    /// print
    /// </summary>
    public void Interact()
    {
        Console.WriteLine("You try to open the {0}. It's locked.", name);
    }
}
/// <summary>
/// class decoration
/// </summary>
public class Decoration : Base, IInteractive, IBreakable
{
    /// <summary>
    /// bool isquest
    /// </summary>
    /// <value></value>
    public bool isQuestItem { set; get; }
    /// <summary>
    /// int durab
    /// </summary>
    /// <value></value>
    public int durability { set; get; }
    /// <summary>
    /// decoration constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="durability"></param>
    /// <param name="isQuestItem"></param>
    public Decoration(string name = "Decoration", int durability = 1, bool isQuestItem = false)
    {
        if (durability <= 0)
            throw new Exception("Durability must be greater than 0");
        else
        {
            this.name = name;
            this.durability = durability;
            this.isQuestItem = isQuestItem;
        }
    }
    /// <summary>
    /// interact impl
    /// </summary>
    public void Interact()
    {
        if (durability <= 0)
            Console.WriteLine("The {0} has been broken.", name);
        else if (isQuestItem == true)
            Console.WriteLine("You look at the {0}. There's a key inside.", name);
        else if (isQuestItem == false)
            Console.WriteLine("You look at the {0}. Not much to see here.", name);
    }
    /// <summary>
    /// break impl
    /// </summary>
    public void Break()
    {
        durability--;
        if (durability > 0)
            Console.WriteLine("You hit the {0}. It cracks.", name);
        else if (durability == 0)
            Console.WriteLine("You smash the {0}. What a mess.", name);
        else Console.WriteLine("The {0} is already broken.", name);
    }
}
/// <summary>
    /// class key
    /// </summary>
    public class Key : Base, ICollectable
    {
        /// <summary>
        /// bool iscoll
        /// </summary>
        /// <value></value>
        public bool isCollected { set; get; }
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isCollected"></param>
        public Key(string name = "Key", bool isCollected = false)
        {
            this.name = name;
            this.isCollected = isCollected;
        }
        /// <summary>
        /// impl collect
        /// </summary>
        public void Collect()
        {
            if (isCollected == false)
            {
                isCollected = true;
                Console.WriteLine("You pick up the {0}.", name);
            }
            else
                Console.WriteLine("You have already picked up the {0}.", name);
        }
    }