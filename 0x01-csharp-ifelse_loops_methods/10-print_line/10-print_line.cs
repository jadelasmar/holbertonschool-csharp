using System;

namespace _10_print_line
{
    class Program
    {
        static void Main(string[] args)
        {
            printLine(3);
            printLine(0);
            printLine(12);
            printLine(-98);
        }

        public static void printLine(int length)
        {
            if(length >0)
            {
                for(int i=0;i<length;i++)
                {
                    Console.Write("_");
                }
                Console.WriteLine();
            }
            else Console.WriteLine();
        }
    }
}
