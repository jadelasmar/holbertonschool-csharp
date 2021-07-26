using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int element = 0;
        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                element++;
            }
            return element;

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

    }
}