using System;

namespace _2._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int [] nums = new int[n];
            for (int i = 0; i < n; i++) { nums[i] = int.Parse(Console.ReadLine()); }
            for (int i = n; i > 0; i--) { Console.Write($"{nums[i - 1]} "); }
        }
    }
}
