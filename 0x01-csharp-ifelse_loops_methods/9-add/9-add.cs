using System;

namespace _9_add
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", addition(1, 2));
            Console.WriteLine("{0}", addition(98, 0));
            Console.WriteLine("{0}", addition(100, -2));
        }

        public static int addition(int a, int b)
        {
            int c = a + b;
            return c;
        }
    }
}
