using System;

namespace _9._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Math.Abs(int.Parse(Console.ReadLine())).ToString();
            int[] nums = new int[input.Length];
            for (int i = 0; i < nums.Length; i++) { nums[i] = input[i] - 48; }
            Console.WriteLine(MultiplyEvensAndOdds(nums));
        }
        static int MultiplyEvensAndOdds(int[] nums)
        {
            int evens = 0, odds = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0) { evens += nums[i]; }
                else { odds += nums[i]; }
            }
            return evens * odds;
        }
    }
}
