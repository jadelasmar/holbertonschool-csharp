using System;
class Program
{
    public static void Reverse(int[] array)
    {
        int[] temp = new int[array];
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(array[i]);
            }
            Console.Write(array[i]);
        }
        if (array == null)
        {
            Console.WriteLine();
        }
    }
}