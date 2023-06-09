public class Program
{
    static void Main(string[] args)
    {
        Thread t1 = new(ThreadMethod);
        Thread t2 = new(ThreadMethod2);
        Thread t3 = new(ThreadMethod3);
        t1.Start();
        t3.Start();
        t2.Start();
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("main thread");
            Thread.Sleep(1000);
        }
    }
    static void ThreadMethod()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("t1 Thread");
            Thread.Sleep(1000);
        }
    }
    static void ThreadMethod2()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("t2 Thread");
            Thread.Sleep(1000);
        }
    }
    static void ThreadMethod3()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("t3 Thread");
            Thread.Sleep(1000);
        }
    }
}