
using System.Collections;
namespace LearnCollections;

public class MixedContainer 
{
    public ArrayList container{ get; set;}

    public MixedContainer()
    {
        container = new ArrayList();
    }

    public void AddToContainer ( object value)
    {
        container.Add(value);
    } 

    public void RemoveFromContainer (int index)
    {
        container.RemoveAt(index);
    }

     public void Show()
    {
        foreach (var item in container)
        {
            Console.WriteLine((string)(object)item);
        }
    }
}