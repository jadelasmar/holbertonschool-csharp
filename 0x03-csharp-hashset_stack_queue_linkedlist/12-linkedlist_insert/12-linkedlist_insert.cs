using System;
using System.Collections.Generic;


class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        int count = myLList.Count;
        if (myLList.Count == 0)
        {
            return myLList.AddFirst(n);
        }


        LinkedListNode<int> node = myLList.First;
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        for (int i = 0; i < count; i++)
        {
            if (newNode.Value < node.Value)
            {
                myLList.AddBefore(node, n);
            }
            node = node.Next;
        }
        return newNode;
    }
}