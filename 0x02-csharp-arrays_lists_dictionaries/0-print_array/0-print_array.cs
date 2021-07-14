using System;

namespace _0_print_array
{
    class Array
    {
        public static int[] CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
            int[] newArr = new int[size];
            if (size == 0)
            {
                Console.WriteLine();
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (i == size - 1)
                    {
                        Console.WriteLine("{0}", i);
                    }
                    else
                    {
                        Console.Write("{0} ", i);
                    }
                }

            }
            return newArr;
        }
    }
}
