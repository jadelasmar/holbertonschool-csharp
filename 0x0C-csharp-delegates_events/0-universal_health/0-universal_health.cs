using System;

/// <summary>
/// class player
/// </summary>
public class Player
{
    string name;
    float maxHp;
    float hp;
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp > 0)
        {
            this.maxHp = maxHp;
        }
        else
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        this.hp = this.maxHp;
    }
    /// <summary>
    /// method to print health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1}/{2} health", name, hp, maxHp);
    }
}