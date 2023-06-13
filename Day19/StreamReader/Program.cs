class Program
{
    static void Main(string[] args)
    {
        string path = "..\\File\\LargeFile.txt";
        using (StreamWriter sw = new StreamWriter(File.Open(path, FileMode.Append)))
        {
            sw.WriteLine("hello world");
        }
        
        using (StreamReader sr = new StreamReader(path))
        {
            Console.WriteLine(sr.ReadToEnd());
            // string line = sr.ReadLine();
            // while (line != null){
            //     Console.WriteLine(line);
            //     line = sr.ReadLine();
            // }
        }
    }
}