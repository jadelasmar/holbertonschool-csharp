using System;

namespace _8_print_last_digit
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=98;
            int b=0;
            int c=-1024;
            printLast(a);
            printLast(b);
            printLast(c);
            printLast(c);
        }

        public static int printLast(int number)
        {
            int last=number%10;
            Console.Write(Math.Abs(last));
            return Math.Abs(last);
        }
    }
}
