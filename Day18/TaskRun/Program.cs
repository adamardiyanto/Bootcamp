using System.Threading.Tasks;
class Program 
{
    static async Task Main(string[] args)
    {
        Task task1 = Task.Run(() => LoopTask());
        //task1.Wait();
        for (int i = 0; i <10; i++)
        {
            Console.WriteLine("output from main");
            await Task.Delay(1000);
        }
        
    }
    static async Task LoopTask()
    {
        for (int i = 0; i<20; i++)
        {
            await Task.Delay(500);
            Console.WriteLine("output from task");
        }
    }
}