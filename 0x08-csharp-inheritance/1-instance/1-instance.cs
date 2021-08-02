using System;

/// <summary>
/// New class obj
/// </summary>
class Obj
{
    /// <summary>
    /// method to check if obj is array
    /// </summary>
    /// <param name="obj"></param>
    /// <returns>true/false</returns>
    public static bool IsInstanceOfArray(object obj)
    {
        if (obj is Array)
            return true;
        else return false;

    }
}