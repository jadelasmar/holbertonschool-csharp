using System;
class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine();
            return;
        }
        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i == 0)
            {
                Console.WriteLine(array[i]);
            }
            Console.Write("{0} ",array[i]);
        }
        
    }
}