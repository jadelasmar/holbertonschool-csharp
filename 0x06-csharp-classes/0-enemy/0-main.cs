using Enemies;
using System;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();
a
        Console.WriteLine("newObject is of type {0}", newObject.GetType());
        Console.WriteLine("String representation: {0}", newObject.ToString());
    }
}