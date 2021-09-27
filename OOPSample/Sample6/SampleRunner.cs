using System;

namespace OOPSample.Sample6
{
    internal class SampleRunner
    {
        public static void Run()
        {
            //TryQueue();
            TryStack();
        }

        private static void TryStack()
        {
            var random = new Random();

            //IStack<short> stack = new Stack<short>();
            IStack<short> stack = new FixedStack<short>(5);
            Console.WriteLine($"Display the stack: {stack}\n");

            const int OpCount = 100;
            for (short i = 0; i < OpCount; i++)
            {
                var op = random.Next(2); //randomly push or pop
                if (op % 2 == 0)
                {
                    try
                    {
                        Console.WriteLine($"trying to add {i} to the stack.");
                        stack.Push(i);
                        Console.WriteLine($"{i} added to the stack.");
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine($"Trying to pop...");
                        short val = stack.Pop();
                        Console.WriteLine($"Popped item:{val}");
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine($"Display the stack: {stack}\n");
            }
        }

        private static void TryQueue()
        {
            var random = new Random();

            IQueue<short> queue = new Queue<short>();
            //IQueue<short> queue = new FixedQueue<short>(5);
            Console.WriteLine($"Display the queue: {queue}\n");

            const int OpCount = 100;
            for (short i = 0; i < OpCount; i++)
            {
                var op = random.Next(2); //randomly enqueue or dequeue
                if (op % 2 == 0)
                {
                    try
                    {
                        Console.WriteLine($"trying to add {i} to the queue.");
                        queue.Enqueue(i);
                        Console.WriteLine($"{i} added to the queue.");
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        Console.WriteLine($"Trying to dequeue...");
                        short val = queue.Dequeue();
                        Console.WriteLine($"Dequeued item:{val}");
                    }
                    catch (NotSupportedException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine($"Display the queue: {queue}\n");
            }
        }
    }
}
