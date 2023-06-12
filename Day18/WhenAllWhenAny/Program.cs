using System.Text;
using System.Threading.Tasks;
class Program
{
    static async Task  Main(string[] args)
    {
        Console.WriteLine("main");
        Task task1 = Task.Run(() => WriteGreen("task1"));
        Task task2 = Task.Run(() => WriteRed("task2"));
        await Task.WhenAll(task1,task2);
    }

    static async Task WriteGreen(string text)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(text);
        Console.ResetColor();
    }
     static async Task WriteRed(string text)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(text);
        Console.ResetColor();
    }
}