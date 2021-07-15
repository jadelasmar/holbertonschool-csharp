using System;
using System.Collections.Generic;

class MyStack
{
    public static Stack<string> Info(Stack<string> aStack, string newItem, string search)

    {
        int number = aStack.Count;
        Console.WriteLine("Number of items: {0}", number);
        bool contain = aStack.Contains(search);
        if (number == 0)
        {
            Console.WriteLine("Stack is empty");
            Console.WriteLine("Stack contains \"{0}\": {1}", search, contain);
            aStack.Push(newItem);
            return aStack;
        }
        string item = aStack.Peek();
        Console.WriteLine("Top item: {0}", item);
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