namespace DeadlockExample
{
    class Program
    {
        static readonly object lock1 = new object();
        static readonly object lock2 = new object();

        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => DeadlockMethod1());
            Thread thread2 = new Thread(() => DeadlockMethod2());

            thread1.Start();
            thread2.Start();

            thread1.Join();
            thread2.Join();
        }

        static void DeadlockMethod1()
        {
            lock (lock1)
            {
                Console.WriteLine("Thread 1 locked lock1");
                Thread.Sleep(1000);

                lock (lock2)
                {
                    Console.WriteLine("Thread 1 locked lock2");
                }
            }
        }

        static void DeadlockMethod2()
        {
            lock (lock2)
            {
                Console.WriteLine("Thread 2 locked lock2");
                Thread.Sleep(1000);

                lock (lock1)
                {
                    Console.WriteLine("Thread 2 locked lock1");
                }
            }
        }
    }
}