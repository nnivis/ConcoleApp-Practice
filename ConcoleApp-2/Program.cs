using System;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;

            MyLinkedList<string> list = new MyLinkedList<string>();

            while (x != 0)
            {
                Console.WriteLine();
                Console.WriteLine("Enter the function code to execute (1, 2 ,3, 4, 5, 6 ) if you want to reach goal 0:");
                x = Convert.ToInt32(Console.ReadLine());

                switch (x)
                {
                    case 1: AddElement(list); break;

                    case 2: Push(list); break;

                    case 3: RemoveElement(list); break;

                    case 4: Pop(list); break;

                    case 5: Peek(list); break;

                    case 6: Clear(list); break;

                }
            }
        }

        static void AddElement(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine("Enter how many items to add to the list:");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string userInput;
                Console.WriteLine($"Entering element number {i} : ");
                userInput = Console.ReadLine();
                list.Add(userInput);
            }

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Time spent on the operation: {stopwatch.ElapsedMilliseconds}");
        }

        static void Push(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string userInput;
            userInput = Console.ReadLine();
            Console.WriteLine($"Enter the element you want to insert instead of the head of the list: ");
            list.Push(userInput);

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Time spent on the operation: {stopwatch.ElapsedMilliseconds}");
        }

        static void RemoveElement(MyLinkedList<string> list)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Console.WriteLine($"Enter the element to be removed: ");
            string target = Convert.ToString(Console.ReadLine());
            list.Remove(target);

            Console.WriteLine(String.Join(" , ", list));

            stopwatch.Stop();
            Console.WriteLine($"Time spent on the operation: {stopwatch.ElapsedMilliseconds}");

        }

        static void Pop(MyLinkedList<string> list)
        {
            list.Pop();

            Console.WriteLine(String.Join(" , ", list));
        }

        static void Peek(MyLinkedList<string> list)
        {
            list.Peek();
        }

        static void Clear(MyLinkedList<string> list)
        {
            list.Clear();

            Console.WriteLine(String.Join(" , ", list));
        }

    }
}
