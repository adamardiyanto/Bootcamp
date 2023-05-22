static class Program{
    static void Main(string[] args){
        const int a = 1;
        const string b = "test";

        (int, string) data = MyMethod(a, b);
        Console.WriteLine($"data.item1 = {data.Item1} , data.item2 = {data.Item2}");

        
    }

    static (int, string) MyMethod(int a, string b){
        return (a,b);
    }
}