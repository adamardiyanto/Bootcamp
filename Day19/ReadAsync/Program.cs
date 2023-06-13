class Program
{
    static async Task Main(string[] args)
    {
        string path = "..\\File\\LargeFile.txt";
        // using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Append)))
        // {
        //     sw.WriteLine("hello world");
        // }
        
        using (StreamReader sr = new StreamReader(path))
        {
            string message = await sr.ReadLineAsync();
            // string message = task.Result;
            Console.WriteLine(message);
        }
        Console.WriteLine("main program");
    }
}