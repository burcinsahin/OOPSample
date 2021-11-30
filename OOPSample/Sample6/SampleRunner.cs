using System;

namespace OOPSample.Sample6
{
    internal class SampleRunner
    {
        public static void Run()
        {
            Console.WriteLine("Try queue?(Y/N):");
            var v = Console.ReadLine();
            if (v.ToLower() == "y")
            {
                TryQueue(new Queue<short>());
                TryQueue(new FixedQueue<short>(5));
            }

            Console.WriteLine("Try stack?(Y/N):");
            v = Console.ReadLine();
            if (v.ToLower() == "y")
            {
                TryStack(new Stack<short>());
                TryStack(new FixedStack<short>(5));
            }

            Console.WriteLine("Try linkedlist?(Y/N):");
            v = Console.ReadLine();
            if (v.ToLower() == "y")
            {
                TryLinkedList(new LinkedList<short>());
            }
        }

        private static void TryStack(IStack<short> stack)
        {
            Console.WriteLine($"Trying {stack.GetType().Name}");

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
            Console.WriteLine($"Trying {queue.GetType().Name}");

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
                        var val = queue.Dequeue();
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

        private static void TryLinkedList(ILinkedList<short> linkedList)
        {
            Console.WriteLine($"Trying {linkedList.GetType().Name}");

            var random = new Random();

            Console.WriteLine($"Display the queue: {linkedList}\n");

            for (var i = 0; i < 100; i++)
            {
                var randomValue = (short)random.Next(1000);
                Console.WriteLine($"Trying to add {randomValue} to the list.");
                linkedList.Add(randomValue);
                Console.WriteLine($"{randomValue} added to the list.");
            }

            for (short i = 0; i < 100; i++)
            {
                var op = random.Next(4); //randomly enqueue or dequeue
                try
                {
                    var randomValue = (short)random.Next(1000);
                    var randomIndex = random.Next(100);

                    switch (op)
                    {
                        case 0://Add
                            Console.WriteLine($"Trying to add {randomValue} to the list.");
                            linkedList.Add(randomValue);
                            Console.WriteLine($"{randomValue} added to the list.");
                            break;
                        case 1://Get
                            Console.WriteLine($"Trying to get...");
                            var val = linkedList.Get(random.Next(100));
                            Console.WriteLine($"get item:{val}");
                            break;
                        case 2://Insert
                            Console.WriteLine($"Trying to insert...");
                            linkedList.Insert(randomIndex, randomValue);
                            Console.WriteLine($"{randomValue} inserted to index:{randomIndex}.");
                            break;
                        case 3://Remove
                            Console.WriteLine($"Trying to remove...");
                            linkedList.Remove(randomIndex);
                            Console.WriteLine($"item removed at index:{randomIndex}.");
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine($"Count: {linkedList.GetCount()}\n");
                Console.WriteLine($"Display the list: {linkedList}\n");
            }
        }
    }
}
