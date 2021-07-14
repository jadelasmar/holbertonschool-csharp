using System;

namespace _0_print_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] newArray;

            newArray = cPrint(10);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = cPrint(16);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = cPrint(0);
            Console.WriteLine("Array Length: " + newArray.Length);
            Console.WriteLine("----------------");
            newArray = cPrint(-10);
        }

        public static int[] cPrint(int siz)
        {
            if (siz < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            int[] numb = new int[siz];
            if (siz == 0)
            {
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < siz; i++)
                {
                    Console.Write("{0}", i);
                    if (i < siz - 1)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
            return numb;
        }
    }
}
