using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if(myList.Count==0)
        {
            return "None";
        }
        List<int> value = new List<int>(myDict.Values);
        int big=0;
        foreach(int element in myList)
        {
            if(big<element)
            {
                big = element;
            }
        }
        return big;
    }
}