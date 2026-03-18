using System;
using System.Collections.Generic;
using System.Text;

namespace KMA.ProgrammingInCSharp2026.Samples
{
    internal class AsyncSample
    {
        private void RunLongOperation()
        {
            Console.WriteLine($"4 Step. Thread: {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"5.{i} Step. Thread: {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"6 Step. Thread: {Thread.CurrentThread.ManagedThreadId}");
        }

        public void Run()
        {
            Console.WriteLine($"3 Step. Thread: {Thread.CurrentThread.ManagedThreadId}");
            RunLongOperation();
            Console.WriteLine($"7 Step. Thread: {Thread.CurrentThread.ManagedThreadId}");            
        }
    }
}
