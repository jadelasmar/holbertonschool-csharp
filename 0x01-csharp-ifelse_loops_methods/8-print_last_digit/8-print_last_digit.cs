using System;
class Program
{
    public static int printLast(int number)
    {
        int last = number % 10;
        Console.Write(Math.Abs(last));
        return Math.Abs(last);
    }
}