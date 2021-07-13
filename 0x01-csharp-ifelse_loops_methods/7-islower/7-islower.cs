using System;

namespace _7_islower
{
    class Program
    {
        static void Main(String[] args)
        {
            char[] letters = { 'a', 'A', 'Q', 'h', '9', 'B', 'g' };
            for ( int i = 0; i < letters.Length; i++)
            {
                if (isLow(letters[i]))
                {
                    Console.WriteLine("{0} is lowercase", letters[i]);
                }
                else Console.WriteLine("{0} is uppercase", letters[i]);
            }

        }
        public static bool isLow(char c)
        {
            if (c >= 'a' && c <= 'z')
                return true;
            else return false;
        }
    }
}
