using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Stack<int> nums = new Stack<int>();
            foreach (int item in input) { nums.Push(item); }
            string[] command = Console.ReadLine().ToLower().Split(' ').ToArray();
            while (command[0] != "end")
            {
                if (command[0] == "add")
                {
                    nums.Push(int.Parse(command[1]));
                    nums.Push(int.Parse(command[2]));
                }
                else
                {
                    if (int.Parse(command[1]) < nums.Count)
                    {
                        for (int i = 0; i < int.Parse(command[1]); i++) { nums.Pop(); }
                    }
                }
                command = Console.ReadLine().ToLower().Split(' ').ToArray();
            }
            foreach (int item in nums) { sum += item; }
            Console.WriteLine("Sum: " + sum);
        }
    }
}
