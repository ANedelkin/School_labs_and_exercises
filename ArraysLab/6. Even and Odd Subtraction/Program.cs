using System;
using System.Linq;

namespace _6._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int sum = 0;
            foreach (int item in nums) { if (item % 2 == 0) { sum += item; } else { sum -= item; } }
            Console.WriteLine(sum);
        }
    }
}
