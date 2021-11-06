using System;

/// <summary>
/// new abstract class
/// </summary>
abstract class Base
{
    public string name
    {
        get;
        set;
    }

    //override of ToString()
    public override string ToString()
    {
        return name + " is a " + GetType().Name;
    }

    /// <summary>
    /// new interface IInteractive
    /// </summary>
    public interface IInteractive
    {
        void Interact();
    }

    /// <summary>
    /// new interface IBreakable
    /// </summary>
    public interface IBreakable
    {
        int durability { get; set; }
        void Break();
    }

    /// <summary>
    /// new interface ICollectable
    /// </summary>
    public interface ICollectable
    {
        bool isCollected { get; set; }
        void Collect();
    }

    public class TestObject : Base, IInteractive, IBreakable, ICollectable
    {
        public int durability { get; set; }
        public bool isCollected { get; set; }
        public void Interact() { }
        public void Break() { }
        public void Collect() { }
    }

}