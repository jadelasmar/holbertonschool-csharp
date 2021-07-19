using System;
class Program
{
    public static void printLine(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
            Console.WriteLine();
        }
        else Console.WriteLine();
    }
}