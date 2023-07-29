using System;
using System.Linq;

namespace _05._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = ("0 " + Console.ReadLine() + " 0").Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            bool no = true;
            for (int i = 1; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < i; j++) { sum += nums[j]; }
                for (int j = i + 1; j < nums.Length; j++) { sum -= nums[j]; }
                if (sum == 0) { Console.Write(i - 1); no = false; break; }
            }
            if (no) { Console.Write("no"); }
        }
    }
}
