using System.Threading.Tasks;
class Program
{
    public CancellationTokenSource cts;
    public CancellationToken token;
    static async Task Main(string[] args)
    {
        cts = new CancellationTokenSource();
        token = cts.Token;
        Task task1 = Task.Run(() => LoopTask(token));
        Task task2 = Task.Run(() => LoopTask2());
        //task1.Wait();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("output from main");
            await Task.Delay(1000);
            if (task2.IsCompleted)
            {
                cts.Cancel();
            }
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
    static async Task LoopTask2()
    {
        for (int i = 0; i < 40; i++)
        {
            await Task.Delay(250);
            Console.WriteLine("output from task2");
            //token.ThrowIfCancellationRequested();
        }
    }
}