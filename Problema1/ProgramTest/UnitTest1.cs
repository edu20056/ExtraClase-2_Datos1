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
        DoubleLinkedList.Node current = list.Get_head(); // Accedemos al head de la lista

        while (current != null)
        {
            // Verificamos si el valor del nodo actual coincide con el valor esperado
            Assert.AreEqual(expectedValues[index], current.Get_Value());
            current = current.Get_Next();
            index++;
        }

        // Verificamos si el tamaño de la lista es el esperado
        Assert.AreEqual(expectedValues.Length, list.Get_Size()); // Comparamos con el tamaño esperado
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

        Assert.AreEqual(x, 1); //La función InsertInOrder mete como cabeza el elemento con menor valor
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
    public void MergeSorted_Test()
    {
        DoubleLinkedList listA = new DoubleLinkedList();
        listA.InsertInOrder(1);
        listA.InsertInOrder(3);
        listA.InsertInOrder(5);

        DoubleLinkedList listB = new DoubleLinkedList();
        listB.InsertInOrder(2);
        listB.InsertInOrder(4);
        listB.InsertInOrder(6);

        DoubleLinkedList expected = new DoubleLinkedList();
        expected.InsertInOrder(1);
        expected.InsertInOrder(2);
        expected.InsertInOrder(3);
        expected.InsertInOrder(4);
        expected.InsertInOrder(5);
        expected.InsertInOrder(6);

        DoubleLinkedList mergedList = new DoubleLinkedList();
        mergedList.MergeSorted(listA, listB, SortDirection.Ascending);

        Assert.AreEqual(expected.ToString(), mergedList.ToString());
    }
}
