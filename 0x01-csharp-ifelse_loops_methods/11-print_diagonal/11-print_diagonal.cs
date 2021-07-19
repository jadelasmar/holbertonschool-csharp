using System;
class Program
{
    public static void printDiagonal(int length)
    {
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (i == j)
                    {
                        Console.Write("\\");
                    }
                    else Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        else Console.WriteLine();
    }
}