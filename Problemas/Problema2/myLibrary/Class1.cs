namespace myLibrary;


public class Node
{
    private int value;
    private Node next;
    private Node prev;

    public Node(int value)
    {
        this.value = value;
        next = null;
        prev = null;
    }

    public int GetValue() => value;
    public Node GetNext() => next;
    public Node GetPrev() => prev;

    public void SetNext(Node next) => this.next = next;
    public void SetPrev(Node prev) => this.prev = prev;
}

// Clase que implementa la lista doblemente enlazada con los métodos básicos
public class DoubleLinkedList
{
    private Node head; // Primer nodo de la lista
    private Node tail; // Último nodo de la lista

    private int size = 0;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
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

    public void Insert(int value)
    {
        Node newNode = new Node(value);

        if (head == null) 
        {
            head = tail = newNode;
        }
        else
        {
            tail.SetNext(newNode);
            newNode.SetPrev(tail);
            tail = newNode;
        }
        size++;
    }

    public int DeleteFirst()
    {
        if (head == null)
            throw new InvalidOperationException("List is empty.");

        int value = head.GetValue();
        head = head.GetNext();

        if (head != null)
            head.SetPrev(null);
        else
        {
            tail = null;
        }

        size--;
        return value;
    }

    // Elimina y devuelve el último elemento
    public int DeleteLast()
    {
        if (tail == null)
            throw new InvalidOperationException("List is empty.");

        int value = tail.GetValue();
        tail = tail.GetPrev();

        if (tail != null)
            tail.SetNext(null);
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

        while (current != null && current.GetValue() != value)
        {
            current = current.GetNext();
        }

        if (current == null) 
            return false;

        if (current == head)
            head = current.GetNext();
        else
            current.GetPrev().SetNext(current.GetNext());

        if (current == tail) 
            tail = current.GetPrev();
        else
        {
            current.GetNext().SetPrev(current.GetPrev());
        }

        size--;
        return true;
    }

    public bool Invertir_Lista()
    {
        if (head == null)
        {
            return false;
        }

        Node current = head;
        Node temp = null;

        while (current != null)
        {
            temp = current.GetNext();
            
            current.SetNext(current.GetPrev());
            current.SetPrev(temp);

            current = temp;
        }

        temp = head;
        head = tail;
        tail = temp;

        return true;
    }

}
