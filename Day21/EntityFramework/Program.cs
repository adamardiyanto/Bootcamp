using EFDatabase;

class Program
{
    static void Main(string[] args)
    {
        Northwind db = new Northwind();
        // Console.WriteLine($"database name : {db.Database}");
        // Console.WriteLine($"provider name : {db.Database.ProviderName}");
    }
}