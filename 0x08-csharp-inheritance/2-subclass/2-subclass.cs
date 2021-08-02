using System;

/// <summary>
/// new class obj
/// </summary>
class Obj
{
/// <summary>
/// method to check obj is subclass
/// </summary>
/// <param name="derivedType"></param>
/// <param name="baseType"></param>
/// <returns>true/false</returns>
    public static bool IsOnlyASubclass(Type derivedType, Type baseType)
    {
        if (derivedType.IsSubclassOf(baseType))
            return true;
        else return false;
    }
}