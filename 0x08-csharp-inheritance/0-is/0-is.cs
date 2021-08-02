using System;
using System.Collections.Generic;

/// <summary>
///new class obj
/// </summary>
class Obj
{
    /// <summary>
    /// method to check if obj is an int
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>true/false</returns>
    public static bool IsOfTypeInt(object obj)
    {
        if (obj is int)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}