using System;
using System.Collections.Generic;
using System.Linq;
using InventoryLibrary;

namespace InventoryManager
{
    class InventoryManager
    {
        public static JSONStorage storage = new JSONStorage();
        public static void Main()
        {
            printPrompt();
            storage.Load();
            while (true)
            {
                Console.WriteLine("Please Enter Command");
                String cmd = Console.ReadLine();
                Queue<string> queue = new Queue<string>(cmd.Split(" "));
                string dequeue = queue.Dequeue();
                switch (dequeue)
                {
                    default:
                        Console.WriteLine("{0} command could not be found", cmd);
                        break;

                    case "ClassNames":
                        Console.WriteLine("executing {0}", dequeue);
                        break;

                    case "All":
                        All(queue);
                        break;

                    case "Create":
                        Create(queue);
                        break;

                    case "Show":
                        Show(queue);
                        break;

                    case "Update":
                        Update(queue);
                        break;

                    case "Delete":
                        Delete(queue);
                        break;

                    case "Exit":
                        Environment.Exit(0);
                        break;

                }
                printPrompt();
            }
        }

        public static void All(Queue<string> queue)
        {
            if (queue.Count == 0)
                foreach (var item in storage.objects)
                    Console.WriteLine("{0} : {1}", item.Key, item.Value);
            else
            {
                string dequeue = queue.Dequeue();
                foreach (var item in storage.objects.Where(item => item.Key.Split(".")[0] == dequeue))
                    Console.WriteLine("{0} : {1}", item.Key, item.Value);
            }
        }

        public static void Create(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string dequeue = queue.Dequeue();
                switch (dequeue)
                {
                    default:
                        Console.WriteLine("{0} is invalid", queue);
                        break;

                    case "Item":
                        Console.WriteLine("Item name : ");
                        string itemName = Console.ReadLine();
                        Item newItem = new Item(itemName);
                        storage.New(newItem);
                        while (true)
                        {
                            Console.WriteLine("Add properties ? (Y/N)");
                            string ans = Console.ReadLine();
                            if (ans == "y" || ans == "Y")
                            {
                                Console.WriteLine("Item description : ");
                                string itemDescription = Console.ReadLine();
                                newItem.description = itemDescription;

                                float price;
                                do
                                {
                                    Console.WriteLine("Item price : ");
                                    string itemPrice = Console.ReadLine();
                                    price = float.Parse(itemPrice);
                                } while (price < 0);
                                newItem.price = price;

                                Console.WriteLine("Tags : (separate by space)");
                                string itemTags = Console.ReadLine();
                                List<string> tags = new List<string>(itemTags.Split(" "));
                                newItem.tags = tags;
                                break;
                            }
                            else if (ans == "n" || ans == "N")
                                break;
                        }
                        storage.Save();
                        Console.WriteLine("Item created successfully");
                        break;

                    case "User":
                        Console.WriteLine("User name : ");
                        string userName = Console.ReadLine();
                        User user = new User(userName);
                        storage.New(user);
                        storage.Save();
                        Console.WriteLine("User created successfully");
                        break;
                }
            }
        }

        public static void Show(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string dequeueName = queue.Dequeue();
                if (dequeueName == "User" || dequeueName == "Item")
                {
                    if (queue.Count > 0)
                    {
                        string dequeueId = queue.Dequeue();
                        while (true)
                        {
                            try
                            {
                                string found = storage.objects.Keys.First(Item => Item.Split(".")[0] == dequeueName && Item.Split(".")[1] == dequeueId);
                                Console.WriteLine(storage.objects[found]);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ID couldnt be found");
                                Console.WriteLine("Try different ID ? (Y/N)");
                                string ans = Console.ReadLine();
                                if (ans == "y" || ans == "Y")
                                {
                                    Console.WriteLine("Please enter new ID for {0}", dequeueName);
                                    dequeueId = Console.ReadLine();
                                }
                                else if (ans == "n" || ans == "N")
                                    break;

                            }
                        }
                    }
                    else Console.WriteLine("Object ID couldnt be found ");
                }
                else Console.WriteLine("{0} is invalid type", dequeueName);
            }
            else Console.WriteLine("Object name couldnt be found ");
        }

        public static void Delete(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string dequeueName = queue.Dequeue();
                if (dequeueName == "User" || dequeueName == "Item")
                {
                    if (queue.Count > 0)
                    {
                        string dequeueId = queue.Dequeue();
                        while (true)
                        {
                            try
                            {
                                string found = storage.objects.Keys.First(Item => Item.Split(".")[0] == dequeueName && Item.Split(".")[1] == dequeueId);
                                storage.objects.Remove(found);
                                storage.Save();
                                Console.WriteLine("{0} deleted", dequeueId);
                                break;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ID couldnt be found");
                                Console.WriteLine("Try different ID ? (Y/N)");
                                string ans = Console.ReadLine();
                                if (ans == "y" || ans == "Y")
                                {
                                    Console.WriteLine("Please enter new ID for {0}", dequeueName);
                                    dequeueId = Console.ReadLine();
                                }
                                else if (ans == "n" || ans == "N")
                                    break;

                            }
                        }
                    }
                    else Console.WriteLine("Object ID couldnt be found ");
                }
                else Console.WriteLine("{0} is invalid type", dequeueName);
            }
            else Console.WriteLine("Object name couldnt be found ");
        }

        public static void Update(Queue<string> queue)
        {
            if (queue.Count > 0)
            {
                string dequeueName = queue.Dequeue();
                if (dequeueName == "User" || dequeueName == "Item")
                {
                    if (queue.Count > 0)
                    {
                        string dequeueId = queue.Dequeue();
                        while (true)
                        {
                            try
                            {
                                string found = storage.objects.Keys.Single(Item => Item.Split(".")[0] == dequeueName && Item.Split(".")[1] == dequeueId);

                                switch (dequeueName)
                                {
                                    default:
                                        Console.WriteLine("{0} is invalid", queue);
                                        break;

                                    case "User":
                                        User user = storage.objects[dequeueName];
                                        Console.WriteLine("name to be updated : ");
                                        string name = Console.ReadLine();
                                        user.name = name;
                                        break;

                                    case "Item":
                                        Item item = storage.objects[found];
                                        Console.WriteLine("item to be updated : ");
                                        string itemName = Console.ReadLine();
                                        item.name = itemName;
                                        while (true)
                                        {
                                            Console.WriteLine("Add properties ? (Y/N)");
                                            string ans = Console.ReadLine();
                                            if (ans == "y" || ans == "Y")
                                            {
                                                Console.WriteLine("Item description : ");
                                                string description = Console.ReadLine();
                                                item.description = description;
                                                float price;
                                                do
                                                {
                                                    Console.WriteLine("Item price : ");
                                                    string itemPrice = Console.ReadLine();
                                                    price = float.Parse(itemPrice);
                                                } while (price < 0);
                                                item.price = price;

                                                Console.WriteLine("Tags : (separate by space)");
                                                string itemTags = Console.ReadLine();
                                                List<string> tags = new List<string>(itemTags.Split(" "));
                                                item.tags = tags;
                                                break;
                                            }
                                            else if (ans == "n" || ans == "N")
                                            {
                                                break;
                                            }
                                            storage.Save();
                                            Console.WriteLine("Item updated successfully");
                                            break;
                                        }
                                        storage.objects.Remove(found);
                                        storage.Save();
                                        Console.WriteLine("{0} deleted", dequeueId);
                                        break;
                                }
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("ID couldnt be found");
                                Console.WriteLine("Try different ID ? (Y/N)");
                                string ans = Console.ReadLine();
                                if (ans == "y" || ans == "Y")
                                {
                                    Console.WriteLine("Please enter new ID for {0}", dequeueName);
                                    dequeueId = Console.ReadLine();
                                }
                                else if (ans == "n" || ans == "N")
                                    break;

                            }
                        }
                    }
                    else Console.WriteLine("Object ID couldnt be found ");
                }
                else Console.WriteLine("{0} is invalid type", dequeueName);
            }
            else Console.WriteLine("Object name couldnt be found ");
        }

        public static void printPrompt()
        {
            string prompt = String.Join(Environment.NewLine, "Inventory Manager",
               "-------------------------",
               "<ClassNames> show all ClassNames of objects",
               "<All> show all objects",
               "<All [ClassName]> show all objects of a ClassName",
               "<Create [ClassName]> a new object",
               "<Show [ClassName object_id]> an object",
               "<Update [ClassName object_id]> an object",
               "<Delete [ClassName object_id]> an object",
               "<Exit>");

            Console.WriteLine(prompt);
        }
    }
}