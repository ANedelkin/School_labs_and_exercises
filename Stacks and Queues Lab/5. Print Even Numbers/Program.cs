using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> queue = new Queue<int>();
            foreach (int item in input) { queue.Enqueue(item); }
            for (int i = 0; i < input.Length; i++)
            {
                if (queue.Peek() % 2 != 0) { queue.Dequeue(); }
                else { queue.Enqueue(queue.Dequeue()); }
            }
            Console.Write(string.Join(", ", queue));
        }
    }
}
