using System.Collections;
namespace LearnCollections;

public class IndividualBox<T>
{
    public T[] array{get; set;}

    public IndividualBox(T[] value)
    {
        //array = new T[dimension];
        array = value;
    }

    public void Replace (int index, T value, T[] array)
    {
        array[index] = value;
    }

    public void Show()
    {
        foreach (var item in array)
        {
            Console.WriteLine((string)(object)item);
        }
    }
}