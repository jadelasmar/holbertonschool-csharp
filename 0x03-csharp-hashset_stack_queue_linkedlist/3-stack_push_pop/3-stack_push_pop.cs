using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)

    {
        int number = aStack.Count;
        Console.WriteLine("Number of items: {0}", number);
        if (number == 0)
        {
            Console.WriteLine("Stack is empty");
        }
        string item = aStack.Peek();
        Console.WriteLine("Top item: {0}", item);
        bool contain = aStack.Contains(search);
        Stack<string> copy = new Stack<string>(aStack);
        if (contain == true)
        {
            string remove = String.Empty;
            Console.WriteLine("Stack contains \"{0}\": {1}", search, contain);
            foreach (string element in copy)
            {
                remove = aStack.Pop();
                if (remove == search)
                {
                    break;
                }
            }
        }
        aStack.Push(newItem);
        return aStack;
    }
}