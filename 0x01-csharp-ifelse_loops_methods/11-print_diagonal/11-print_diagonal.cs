using System;

namespace _11_print_diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            printDiagonal(3);
            printDiagonal(0);
            printDiagonal(12);
            printDiagonal(-98);
        }

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
}
