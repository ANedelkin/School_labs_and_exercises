using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> nums = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] com = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                Queue<int> command = new Queue<int>();
                for (int j = 0; j < com.Length; j++) { command.Enqueue(com[j]); }
                switch (command.Dequeue())
                {
                    case 1:
                        nums.Push(command.Dequeue());
                        break;
                    case 2:
                        if (nums.Count > 0) { nums.Pop(); }
                        break;
                    case 3:
                        if (nums.Count > 0) { PrintMax(nums); }
                        break;
                    case 4:
                        if (nums.Count > 0) { PrintMin(nums); }
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", nums));
        }
        static void PrintMin(Stack<int> q)
        {
            int[] queue = q.ToArray();
            int smallest = int.MaxValue;
            for (int i = 0; i < q.Count; i++)
            {
                if (smallest > queue[i]) { smallest = queue[i]; }
            }
            Console.WriteLine(smallest);
        }
        static void PrintMax(Stack<int> q)
        {
            int[] queue = q.ToArray();
            int biggest = int.MinValue;
            for (int i = 0; i < q.Count; i++)
            {
                if (biggest < queue[i]) { biggest = queue[i]; }
            }
            Console.WriteLine(biggest);
        }
    }
}
