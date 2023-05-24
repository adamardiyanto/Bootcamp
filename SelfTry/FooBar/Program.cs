class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukan input");
        int input;
        int.TryParse((Console.ReadLine()),out input);
        Console.WriteLine(input);
    }


}

class Checker
{
    private int _number;
    public void CheckInput(int input)
    {
        _number = input;
        for (int i = 0; i < _number; i++)
        {
            string foo = FooBar.Foo(i);
            string bar = FooBar.Bar(i);
            if (foo != null )
            {
                
            }

        }

    }
}

class FooBar
{
    public string Foo(int input)
    {
        if (input % 3 == 0) return "foo";
    }

    public string Foo(int input)
    {
        if (input % 3 == 0) return "foo";
    }
}