using System;
using System.Collections.Generic;
class Dictionart
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        foreach (KeyValuePair<string, int> kvp in myDict)
        {
            myDict[kvp.Key] = kvp.Value * 2;
        }
        return myDict;
    }
}