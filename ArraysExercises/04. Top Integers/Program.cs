using System;
using System.Linq;

namespace _04._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = (Console.ReadLine() + " " + int.MinValue).Split(' ').Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length - 1; i++)
            {
                bool f = true;
                for (int j = i + 1; j < nums.Length; j++) { if (nums[i] <= nums[j]) { f = false; break; } }
                if (f) { Console.Write(nums[i] + " "); }
            }
        }
    }
}
