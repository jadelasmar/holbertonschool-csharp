using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int numbers = 0; numbers <= 98; numbers++)
            {
                var hex = numbers.ToString("X");
                Console.WriteLine("{0} = 0x{1}",numbers,hex);
            }
        }
    }
}
