using System;

namespace Enemies
{
    ///<summary>Creation of public class Zombie</summary>
    public class Zombie
    {
        ///<summary>Creation of int health</summary>
        private int health;
        ///<summary>Creation of public constructor for Zombie and Setting health to 0</summary>
        public Zombie()
        {
            health = 0;
        }
        ///<summary>Creation of public constructor with exception</summary>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                health = value;
            }
        }
        ///<summary>Creation of method that return Health</summary>
        public int GetHealth()
        {
            return health;
        }
    }
}