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
}