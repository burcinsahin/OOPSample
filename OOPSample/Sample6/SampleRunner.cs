using System;

namespace OOPSample.Sample6
{
    internal class SampleRunner
    {
        public static void Run()
        {
            Console.WriteLine("Trying linkedlist queue...");
            var queue = new Queue<short>();
            TryQueue(queue);

            Console.WriteLine("Trying fixed queue...");
            var fixedQueue = new FixedQueue<short>(5);
            TryQueue(fixedQueue);

            Console.WriteLine("Trying linkedlist stack...");
            var stack = new Stack<short>();
            TryStack(stack);

            Console.WriteLine("Trying fixed stack...");
            var fixedStack = new FixedStack<short>(5);
            TryStack(fixedStack);
        }

        private static void TryStack(IStack<short> stack)
        {
            var random = new Random();

            Console.WriteLine($"Display the stack: {stack}\n");

            const int OpCount = 100;
            for (short i = 0; i < OpCount; i++)
            {
                var op = random.Next(2); //randomly push or pop

                try
                {
                    if (op % 2 == 0)
                    {
                        Console.WriteLine($"Trying to add {i} to the stack.");
                        stack.Push(i);
                        Console.WriteLine($"{i} added to the stack.");
                    }
                    else
                    {
                        Console.WriteLine($"Trying to pop...");
                        var val = stack.Pop();
                        Console.WriteLine($"Popped item:{val}");
                    }
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine($"Display the stack: {stack}\n");
            }
        }

        private static void TryQueue(IQueue<short> queue)
        {
            var random = new Random();

            Console.WriteLine($"Display the queue: {queue}\n");

            const int OpCount = 100;
            for (short i = 0; i < OpCount; i++)
            {
                var op = random.Next(2); //randomly enqueue or dequeue
                try
                {
                    if (op % 2 == 0)
                    {
                        Console.WriteLine($"Trying to add {i} to the queue.");
                        queue.Enqueue(i);
                        Console.WriteLine($"{i} added to the queue.");
                    }
                    else
                    {
                        Console.WriteLine($"Trying to dequeue...");
                        short val = queue.Dequeue();
                        Console.WriteLine($"Dequeued item:{val}");
                    }
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }


                Console.WriteLine($"Display the queue: {queue}\n");
            }
        }
    }
}
