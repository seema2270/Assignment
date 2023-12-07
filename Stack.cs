using System;
using System.Collections;
using System.Collections.Generic;

public class Stack<T> : IEnumerable<T>
{
    private List<T> items;

    // Constructor
    public Stack()
    {
        items = new List<T>();
    }

    // Method to add an item to the top of the stack
    public void Push(T item)
    {
        items.Add(item);
    }

    // Method to remove and return the top item from the stack
    public T Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        T poppedItem = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return poppedItem;
    }

    // Method to return the top item from the stack without removing it
    public T Peek()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }

        return items[items.Count - 1];
    }

    // Method to check if the stack is empty
    public bool IsEmpty()
    {
        return items.Count == 0;
    }

    // Implementation of IEnumerable<T> to support foreach iteration
    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    // Explicit implementation of IEnumerable to support foreach iteration
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}