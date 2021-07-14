using System;

class Array
{
    public static int[] ReplaceElement(int[] array, int index, int n)
    {
        int[] updatedArray = (int[])array.Clone();
       if (index < 0 || index >= array.Length)
        {
            Console.WriteLine("Index out of range");
            return array;
        }
        updatedArray[index] = n;
        return updatedArray;
    }
}