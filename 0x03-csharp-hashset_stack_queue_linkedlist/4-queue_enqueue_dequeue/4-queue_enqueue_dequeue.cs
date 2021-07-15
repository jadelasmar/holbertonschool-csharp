using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        int number = aQueue.Count;
        Console.WriteLine("Number of items: {0}", number);
        string item = aQueue.Peek();
        if (number > 0)
        {
            Console.WriteLine("First item: {0}", item);
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }
        aQueue.Enqueue(newItem);
        bool contain = aQueue.Contains(search);
        Console.WriteLine("Queue contains {0}: {1}", search, contain);
        Stack<string> copy = new Stack<string>(aQueue);
        string remove = String.Empty;
        if (contain == true)
        {
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