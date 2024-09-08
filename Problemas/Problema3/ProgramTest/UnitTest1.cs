using myLibrary;

namespace ProgramTest;

[TestClass]
public class DoubleLinkedListTest
{
    [TestMethod]
    public void Añadir_Valors_Correctamente()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(8);
        list.InsertInOrder(3);
        list.InsertInOrder(1);

        int[] expectedValues = { 1, 2, 3, 5, 8 };
        int index = 0;
        DoubleLinkedList.Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.Get_Value());
            current = current.Get_Next();
            index++;
        }


        Assert.AreEqual(expectedValues.Length, list.Get_Size()); 
    }
    [TestMethod]
    public void Get_Head_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        DoubleLinkedList.Node head = list.Get_head();
        int x = head.Get_Value();

        Assert.AreEqual(x, 1); 
    }
    [TestMethod]
    public void Get_Tail_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        DoubleLinkedList.Node head = list.Get_tail();
        int x = head.Get_Value();

        Assert.AreEqual(x, 8); 
    }
    [TestMethod]
    public void Get_Size_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        DoubleLinkedList.Node current = list.Get_head();

        int actual_size = 0;
        while (current != null)
        {
            current = current.Get_Next();
            actual_size++;
        }

        Assert.AreEqual(actual_size, list.Get_Size());
    }

    [TestMethod]
    public void Delete_First_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        list.DeleteFirst();
        
        int[] expectedValues = {2, 3, 5, 8 };
        int index = 0;
        DoubleLinkedList.Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.Get_Value());
            current = current.Get_Next();
            index++;
        }
    }

    [TestMethod]
    public void Delete_Last_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        list.DeleteLast();
        
        int[] expectedValues = {1, 2, 3, 5 };
        int index = 0;
        DoubleLinkedList.Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.Get_Value());
            current = current.Get_Next();
            index++;
        }
    }

    [TestMethod]
    public void Delete_Value_Test()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        list.DeleteValue(2);
        
        int[] expectedValues = {1, 3, 5, 8 };
        int index = 0;
        DoubleLinkedList.Node current = list.Get_head(); 

        while (current != null)
        {
            Assert.AreEqual(expectedValues[index], current.Get_Value());
            current = current.Get_Next();
            index++;
        }
    }

    [TestMethod]
    public void Get_Midle_Even_Size()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);
        list.InsertInOrder(4);

        int[] expectedValues = {1, 2, 3, 4, 5, 8 }; 
        int middle = 4;

        Assert.AreEqual(middle, list.GetMiddle());
    }

    [TestMethod]
    public void Get_Midle_Odd_Size()
    {
        DoubleLinkedList list = new DoubleLinkedList();

        list.InsertInOrder(5);
        list.InsertInOrder(2);
        list.InsertInOrder(1);
        list.InsertInOrder(8);
        list.InsertInOrder(3);

        
        int[] expectedValues = {1, 2, 3, 5, 8 }; 
        int middle = 3;

        Assert.AreEqual(middle, list.GetMiddle());
    }

}
