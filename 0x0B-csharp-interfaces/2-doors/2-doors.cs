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