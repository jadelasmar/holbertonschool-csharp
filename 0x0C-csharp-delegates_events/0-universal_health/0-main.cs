using System;

class Program
{
    static void Main(string[] args)
    {
        Player player1 = new Player("Electric Mouse", -10f);
        Player player2 = new Player("Electric Mouse");
        Player player3 = new Player();
        Player player4 = new Player("Water Turtle",-50f);




        player1.PrintHealth();
        player2.PrintHealth();
        player3.PrintHealth();
        player4.PrintHealth();
    }
}