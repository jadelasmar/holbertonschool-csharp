using System.Collections.Generic;
using System;
using System.IO;
using System.Text.Json;

namespace InventoryLibrary
{
    /// <summary>
    /// class jsonStorage
    /// </summary>
    public class JSONStorage
    {
        /// <summary>dict object </summary>
        public Dictionary<string, dynamic> objects = new Dictionary<string, dynamic>();

        /// <summary>
        /// return objects
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, dynamic> All()
        {
            return this.objects;
        }

        /// <summary>
        /// add new key-value
        /// </summary>
        /// <param name="obj"></param>
        public void New(dynamic obj)
        {
            try
            {
                objects.Add(obj.GetType().Name + "." + obj.id, obj);
            }
            catch (Exception)
            {
                Console.WriteLine("only class inherited from BaseClase");
            }
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
}