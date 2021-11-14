using System;
/// <summary>
/// new class user
/// </summary>
public class User : BaseClass
{
    public string name;

    public string name
    {
        get { return name; }
        set
        {
            name = value;
        }
    }

    public User(string name) : base()
    {
        this.name = name;
    }
}