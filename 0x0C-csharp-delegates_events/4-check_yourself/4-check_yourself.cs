using System;

delegate void CalculateHealth(float num);

/// <summary>
/// delegate to calc
/// </summary>
/// <param name="baseValue"></param>
/// <param name="modifier"></param>
/// <returns></returns>
public delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary>
/// enum for attacks
/// </summary>
public enum Modifier
{
    /// <summary>
    /// weak attack
    /// </summary>
    Weak,
    /// <summary>
    /// base attack
    /// </summary>
    Base,
    /// <summary>
    /// strong attack
    /// </summary>
    Strong
}
/// <summary>
/// class currentHp
/// </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary>
    /// current hp
    /// </summary>
    /// <value></value>
    public float currentHp { get; }
    /// <summary>
    /// construct
    /// </summary>
    /// <param name="newHp"></param>
    public CurrentHPArgs(float newHp)
    {
        this.currentHp = newHp;
    }
}
/// <summary>
/// class player
/// </summary>
public class Player
{
    string name { set; get; }
    float maxHp { set; get; }
    float hp { set; get; }
    string status { set; get; }
    /// <summary>
    /// event handler to check hp
    /// </summary>
    event EventHandler<CurrentHPArgs> HPCheck;
    /// <summary>
    /// constructor
    /// </summary>
    /// <param name="name"></param>
    /// <param name="maxHp"></param>
    public Player(string name = "Player", float maxHp = 100f)
    {
        this.name = name;
        if (maxHp < 0)
        {
            maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else this.maxHp = maxHp;
        hp = maxHp;
        status = name + " is ready to go!";
        HPCheck += CheckStatus;
    }
    /// <summary>
    /// method to check hp
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == maxHp)
            Console.WriteLine("{0} is in perfect health!", name);
        else if (e.currentHp >= maxHp / 2 && e.currentHp < maxHp)
            Console.WriteLine("{0} is doing well!", name);
        else if (e.currentHp >= maxHp / 4 && e.currentHp < maxHp / 2)
            Console.WriteLine("{0} isn't doing too great...", name);
        else if (e.currentHp > 0 && e.currentHp < maxHp / 4)
            Console.WriteLine("{0} needs help!", name);
        else if (e.currentHp == 0)
            Console.WriteLine("{0} is knocked out!", name);
    }

    /// <summary>
    /// method to print Damage
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(float damage)
    {
        if (damage >= 0)
        {
            Console.WriteLine("{0} takes {1} damage!", name, damage);
            ValidateHP(hp - damage);
        }
        else Console.WriteLine("{0} takes 0 damage!", name);

    }
    /// <summary>
    /// method to print Heal
    /// </summary>
    /// <param name="heal"></param>
    public void HealDamage(float heal)
    {
        if (heal >= 0)
        {
            Console.WriteLine("{0} heals {1} HP!", name, heal);
            ValidateHP(hp + heal);
        }
        else Console.WriteLine("{0} heals 0 HP!", name);
    }
    /// <summary>
    /// method to validate hp
    /// </summary>
    /// <param name="newHp"></param>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0)
            hp = 0;
        else if (newHp > maxHp)
            hp = maxHp;
        else hp = newHp;
        HPCheck.Invoke(this,new CurrentHPArgs(hp));
    }
    /// <summary>
    /// method to print health
    /// </summary>
    public void PrintHealth()
    {
        Console.WriteLine("{0} has {1} / {2} health", name, hp, maxHp);
    }

    /// <summary>
    /// method to apply dmg
    /// </summary>
    /// <param name="baseValue"></param>
    /// <param name="modifier"></param>
    /// <returns></returns>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Weak)
            return baseValue / 2f;
        else if (modifier == Modifier.Base)
            return baseValue;
        else return baseValue * 1.5f;
    }

}