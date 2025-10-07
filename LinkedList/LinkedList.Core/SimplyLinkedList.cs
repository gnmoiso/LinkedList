using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Core;

public class SimplyLinkedList<T>
{
    private SimpleNode<T>? head;

    public SimplyLinkedList()
    {
        head = null;
    }

    public void InsrtAtBeginning(T data)
    {
        var newNode = new SimpleNode<T>(data);
        newNode.Next = head;
        head = newNode;
    }

    public void InsrtAtEnd(T data)
    {
        var newNode = new SimpleNode<T>(data);
        if (head == null)
        {
            head = newNode;
            return;
        }
        var current = head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public void PrintList()
    {
        var current = head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}