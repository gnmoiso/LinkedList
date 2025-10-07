using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Core;

public class SimplyLinkedList<T>
{
    private SimpleNode<T>? _head;

    public SimplyLinkedList()
    {
        _head = null;
    }

    public void InsrtAtBeginning(T data)
    {
        var newNode = new SimpleNode<T>(data);
        newNode.Next = _head;
        _head = newNode;
    }

    public void InsrtAtEnd(T data)
    {
        var newNode = new SimpleNode<T>(data);
        if (_head == null)
        {
            _head = newNode;
            return;
        }
        var current = _head;
        while (current.Next != null)
        {
            current = current.Next;
        }
        current.Next = newNode;
    }

    public bool Contains(T data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data!.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public void Remove(T data)
    {
        if (_head == null)
        {
            return;
        }
        if (_head.Data!.Equals(data))
        {
            _head = _head.Next;
            return;
        }

        SimpleNode<T> current = _head;
        while (current.Next != null && !current.Next.Data!.Equals(data))
        {
            current = current.Next;
        }
        if (current.Next != null)
        {
            current.Next = current.Next.Next;
        }
    }

    public void Reverse()
    {
        SimpleNode<T>? prev = null;
        SimpleNode<T> current = _head!;
        SimpleNode<T>? next = null;
        while (current != null)
        {
            next = current.Next;
            current.Next = prev;
            prev = current;
            current = next!;
        }
        _head = prev;
    }

    public void PrintList()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write($"{current.Data} -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }
}