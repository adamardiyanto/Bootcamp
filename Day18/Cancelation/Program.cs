using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        CancellationTokenSource cts = new CancellationTokenSource();
        CancellationToken token = cts.Token;
        Task task1 = Task.Run(() => LoopTask(token));
        Task task2 = Task.Run(() => LoopTask2(token));
        //task1.Wait();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("output from main");
            await Task.Delay(1000);
            Console.WriteLine("Press 'c' to cancel the operation.");
            if (Console.ReadKey().KeyChar == 'c')
            {
                cts.Cancel();
            }
            if (task2.IsCompleted)
            {
                cts.Cancel();
            }
            Console.WriteLine("task 1 : {0}", task1.Status);
            Console.WriteLine("task 2 : {0}", task2.Status);
        }

    }
    static async Task LoopTask(CancellationToken token)
    {
        for (int i = 0; i < 20; i++)
        {
            await Task.Delay(500);
            Console.WriteLine("output from task");
            token.ThrowIfCancellationRequested();
        }
    }
    static async Task LoopTask2(CancellationToken token)
    {
        for (int i = 0; i < 30; i++)
        {
            await Task.Delay(250);
            Console.WriteLine("output from task2");
            token.ThrowIfCancellationRequested();
        }
    }
}