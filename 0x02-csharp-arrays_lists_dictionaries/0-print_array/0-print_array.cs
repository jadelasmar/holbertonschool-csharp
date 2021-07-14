using System;
class Array
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

    public static int[] cPrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] numb = new int[size];
        if (size == 0)
        {
            Console.WriteLine();
            return numb;
        }
        else
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0}", i);
                if (i < size - 1)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("\n");
                }
            }
        }
        return numb;
    }
}