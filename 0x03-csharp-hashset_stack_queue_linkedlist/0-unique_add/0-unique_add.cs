using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        foreach (int element in myList)
        {
            sum += element;
        }
        return sum;
    }
}