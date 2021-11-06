using System;

/// <summary>
/// generic queue class
/// </summary>
/// <typeparam name="T"></typeparam>
class Queue<T>
{
    public Node head;
    public Node tail;
    public int count;

    /// <summary>
    /// method to get type
    /// </summary>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// new class Node
    /// </summary>
    public class Node
    {
        public T value;
        public Node next = null;

        /// <summary>
        /// constructor
        /// </summary>
        public Node(T value)
        {
            this.value = value;
        }
    }


    /// <summary>
    /// add new node
    /// </summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);

        //if head null, head is the new node
        if (head == null)
            head = node;
        else
            tail.next = node;
        tail = node;
        count++;
    }

    /// <summary>
    /// get number of nodes
    /// </summary>
    /// <returns>count</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// remove head and return value
    /// </summary>
    /// <returns></returns>
    public T Dequeue()
    {
        //return head if not empty
        if (head != null)
        {
            T value = head.value;
            head = head.next;
            count--;
            return value;
        }
        //if node empty
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    /// <summary>
    /// peek at head
    /// </summary>
    public T Peek()
    {
        if (head != null)
            return head.value;
        else
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
    }

    /// <summary>
    /// method to print node
    /// </summary>
    public void Print()
    {
        if (head != null)
        {
            Node n = head;
            while (n != null)
            {
                Console.WriteLine(n.value);
                n = n.next;
            }
        }
        else Console.WriteLine("Queue is empty");
    }
}