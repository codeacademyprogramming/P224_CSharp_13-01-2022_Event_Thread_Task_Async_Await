using System;
using System.Threading;

namespace ThreadTaskAsyncAwait
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Loop1);
            Thread thread2 = new Thread(Loop2);

            thread1.Start();
            thread2.Start();

            thread1.Join();

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Main : {i} ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        static void Loop1()
        {
            //Thread.Yield();
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop1 : {i} ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }
        }

        static void Loop2()
        {
            //int a = 1000;
            //Thread.Sleep(a);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Loop2 : {i} ManagedThreadId: {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
