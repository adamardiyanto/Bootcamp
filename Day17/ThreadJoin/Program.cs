﻿public class Example
{
    static Thread thread1, thread2;

    public static void Main()
    {
        thread1 = new Thread(ThreadProc);
        thread1.Name = "Thread1";
        thread1.Start();

        thread2 = new Thread(ThreadProc);
        thread2.Name = "Thread2";
        thread2.Start();
        Console.ReadKey();
    }

    private static void ThreadProc()
    {
        Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        if (Thread.CurrentThread.Name == "Thread1" &&
            thread2.ThreadState != ThreadState.Unstarted)
        {
            thread2.Join();
            //thread1.Join();
        }


        Thread.Sleep(4000);
        Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
        Console.WriteLine("Thread1: {0}", thread1.ThreadState);
        Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
    }
}