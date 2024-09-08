using myLibrary;
namespace ProgramTest;

[TestClass]
public class DoubleLinkedList_Test
{
    [TestMethod]
    public void Get_Head_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        Node head = list.Get_head();
        int x = head.GetValue();

        Assert.AreEqual(x, 5); //La función InsertInOrder mete como cabeza el elemento con menor valor
    }
    [TestMethod]
    public void Get_Tail_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);
        
        Node head = list.Get_tail();
        int x = head.GetValue();

        Assert.AreEqual(x, 3); 
    }
    [TestMethod]
    public void Get_Size_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        Node current = list.Get_head();

        int actual_size = 0;
        while (current != null)
        {
            current = current.GetNext();
            actual_size++;
        }

        Assert.AreEqual(actual_size, list.Get_Size());
    }

    [TestMethod]
    public void Delete_First_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        list.DeleteFirst();
        
        int[] expectedValues = {2, 1, 8, 3 };
        int index = 0;
        Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.GetValue());
            current = current.GetNext();
            index++;
        }
    }

    [TestMethod]
    public void Delete_Last_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        list.DeleteLast();
        
        int[] expectedValues = {5, 2, 1, 8 };
        int index = 0;
        Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.GetValue());
            current = current.GetNext();
            index++;
        }
    }

    [TestMethod]
    public void Delete_Value_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        list.DeleteValue(2);
        
        int[] expectedValues = {5, 1, 8, 3};
        int index = 0;
        Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.GetValue());
            current = current.GetNext();
            index++;
        }
    }

    [TestMethod]
    public void Invertir_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.Insert(5);
        list.Insert(2);
        list.Insert(1);
        list.Insert(8);
        list.Insert(3);

        list.Invertir_Lista();

        int[] expectedValues = {3, 8, 1, 2, 5}; 
        int index = 0;
        Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.GetValue());
            current = current.GetNext();
            index++;
        }
    }
}