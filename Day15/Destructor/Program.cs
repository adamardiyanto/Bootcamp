public class TryDestructor
{
    public TryDestructor()
    {
        Console.WriteLine("Object created");
    }
    ~TryDestructor()
    {
        Console.WriteLine("Object destroyed");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        TryDestructor obj1 = new TryDestructor();
        TryDestructor obj2 = new TryDestructor();

        

        for(int i = 0; i< 1000000000; i++)
        {
            obj1 = null;
            GC.Collect();
            //int a = i;
        }
    }
}