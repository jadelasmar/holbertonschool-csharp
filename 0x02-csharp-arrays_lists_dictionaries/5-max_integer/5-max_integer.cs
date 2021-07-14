using System;
using System.Collections.Generic;
class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.isEmpty())
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];
        foreach (int element in myList)
        {
            if (max <= element)
            {
                max = element;
            }
        }
        return max;
    }
}