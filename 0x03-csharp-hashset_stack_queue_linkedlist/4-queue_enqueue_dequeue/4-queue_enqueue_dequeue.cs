using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
       int number = aQueue.Count;
       Console.WriteLine("Number of items: {0}",number);
       bool contain = aQueue.Contains(search);
       if (number == 0)
        {
            Console.WriteLine("Queue is empty");
            aQueue.Enqueue(newItem);
            return aQueue;
        }
        string item = aQueue.Peek();
        Console.WriteLine("First item: {0}", item);
        aQueue.Enqueue(newItem);
        Stack<string> copy = new Stack<string>(aQueue);
        if (contain == true)
        {
            string remove = String.Empty;
            Console.WriteLine("Queue contains \"{0}\": {1}", search, contain);
            foreach (string element in copy)
            {
                remove = aQueue.Dequeue();
                if (remove == search)
                {
                    break;
                }
            }
        }
        return aQueue;
    }
}