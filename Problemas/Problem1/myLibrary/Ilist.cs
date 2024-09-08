namespace myLibrary;
public interface IList 
    // Interfaz que define los métodos necesarios para manejar una lista genérica.
    // Las clases que implementen esta interfaz deben proporcionar la lógica para
    // insertar, eliminar y manejar elementos dentro de la lista.
{
    void InsertInOrder(int value);
    int DeleteFirst();
    int DeleteLast();
    bool DeleteValue(int value);
    void MergeSorted(IList listA, IList listB, SortDirection direction);
}

public enum SortDirection
{
    Ascending,
    Descending
}
