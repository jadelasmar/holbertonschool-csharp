using System.Runtime.Serialization.Json;
using System.Collections.Generic;
using System;
public class JSONStorage
{
    /// <summary>
    /// new dict
    /// </summary>
    /// <typeparam name="string"></typeparam>
    /// <typeparam name="object"></typeparam>
    /// <returns></returns>
    public Dictionary<string, object> objects = new Dictionary<string, object>();

    /// <summary>
    /// return objects
    /// </summary>
    /// <returns></returns>
    public Dictionary<string, object> All()
    {
        return objects;
    }

    /// <summary>
    /// add new key-value
    /// </summary>
    /// <param name="obj"></param>
    public void New(object obj)
    {
        if (obj != null)
            objects.Add(obj.GetType().Name + "." + obj.id, obj);
    }
    /// <summary>
    /// serialize and save
    /// </summary>
    public void Save()
    {
        string jsonString = JsonSerializer.Serialize(objects);
        File.WriteAllText("storage/inventory_manager.json", jsonString);
    }
    /// <summary>
    /// load and deserialize
    /// </summary>
    public void Load()
    {
        string path = "storage/inventory_manager.json";
        string jsonString = File.ReadAllText(path);
        objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
    }
}