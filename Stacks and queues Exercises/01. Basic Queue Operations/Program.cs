using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] commands = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Queue<int> nums = new Queue<int>();
            for (int i = 0; i < commands[0]; i++) { nums.Enqueue(input[i]); }
            for (int i = 0; i < commands[1]; i++) { nums.Dequeue(); }
            int l = nums.Count, smallest = int.MaxValue;
            bool f = true;
            if (nums.Count == 0) { Console.WriteLine(0); }
            else
            {
                for (int i = 0; i < l && f; i++)
                {
                    int n = nums.Dequeue();
                    if (commands[2] == n) { Console.WriteLine("true"); f = false; }
                    else if (smallest > n) { smallest = n; }
                }
                if (f) { Console.WriteLine(smallest); }
            }
        }
    }
}
