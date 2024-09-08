﻿namespace myLibrary;
public class DoubleLinkedList
{
    public class Node
    {
        private int element;
        private Node next;
        private Node previous;

        public Node(int element)
        {
            this.element = element;
            this.next = null;
            this.previous = null;
        }

        public Node Get_Next()
        {
            return next;
        }

        public Node Get_Prev()
        {
            return previous;
        }

        public void Set_Next(Node x)
        {
            next = x;
        }

        public int Get_Value()
        {
            return element;
        }

        public void Set_Prev(Node x)
        {
            previous = x;
        }
    }

    private Node head;
    private Node tail;
    private int size;

    public DoubleLinkedList()
    {
        this.size = 0;
        this.head = null;
        this.tail = null;
    }

    public Node Get_head()
    {
        return head;
    }

    public Node Get_tail()
    {
        return tail;
    }

    public int Get_Size()
    {
        return size;
    }
    public void InsertInOrder(int value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            Node current = head;
            Node prev = null;

            while (current != null && current.Get_Value() < value)
            {
                prev = current;
                current = current.Get_Next();
            }

            if (prev == null) // Insert before head
            {
                newNode.Set_Next(head);
                head.Set_Prev(newNode);
                head = newNode;
            }
            else
            {
                newNode.Set_Next(current);
                newNode.Set_Prev(prev);
                prev.Set_Next(newNode);

                if (current != null)
                {
                    current.Set_Prev(newNode);
                }
                else
                {
                    tail = newNode;
                }
            }
        }
        size++;
    }

    public int DeleteFirst()
    {
        if (head == null) throw new InvalidOperationException("List is empty.");

        int value = head.Get_Value();
        head = head.Get_Next();

        if (head != null)
        {
            head.Set_Prev(null);
        }
        else
        {
            tail = null;
        }
        size--;

        return value;
    }

    public int DeleteLast()
    {
        if (tail == null) throw new InvalidOperationException("List is empty.");

        int value = tail.Get_Value();
        tail = tail.Get_Prev();

        if (tail != null)
        {
            tail.Set_Next(null);
        }
        else
        {
            head = null;
        }
        size--;

        return value;
    }

    public bool DeleteValue(int value)
    {
        Node current = head;

        while (current != null && current.Get_Value() != value)
        {
            current = current.Get_Next();
        }

        if (current == null) return false; // Value not found

        if (current == head)
        {
            DeleteFirst();
        }
        else if (current == tail)
        {
            DeleteLast();
        }
        else
        {
            current.Get_Prev().Set_Next(current.Get_Next());
            current.Get_Next().Set_Prev(current.Get_Prev());
            size--;
        }

        return true;
    }

    public int GetMiddle()
    {
        if (head == null) throw new InvalidOperationException("List is empty.");

        Node slow = head;
        Node fast = head;

        while (fast != null && fast.Get_Next() != null)
        {
            slow = slow.Get_Next();
            fast = fast.Get_Next().Get_Next();
        }

        return slow.Get_Value();
    }
}
