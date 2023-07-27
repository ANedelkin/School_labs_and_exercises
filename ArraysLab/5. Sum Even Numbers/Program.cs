﻿using System;
using System.Linq;

namespace _5._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int item in nums) { if(item % 2 == 0) { sum += item; } }
            Console.WriteLine(sum);
        }
    }
}
