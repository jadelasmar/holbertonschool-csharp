using System;
using System.Reflection;
/// <summary>
/// new class obj
/// </summary>
class Obj
{
    /// <summary>
    /// method to print properties and methods of obj
    /// </summary>
    /// <param name="myObj"></param>
    public static void Print(object myObj)
    {
        TypeInfo t = myObj.GetType().GetTypeInfo();
        Console.WriteLine("{0} Properties:", t.Name);


        foreach (PropertyInfo p in t.GetProperties())
        {
            Console.WriteLine(p.Name);
        }
        Console.WriteLine("{0} Methods:", t.Name);
        foreach (MethodInfo m in t.GetMethods())
        {
            Console.WriteLine(m.Name);
        }
    }
}