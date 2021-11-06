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
}