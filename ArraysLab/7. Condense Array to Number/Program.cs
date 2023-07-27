using System;
using System.Linq;

namespace _7._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for (int i = 0; i < nums.Length - 1; i++) 
            { 
                for (int j = 0; j < nums.Length - 1; j++) 
                { 
                    nums[j] += nums[j + 1]; 
                } 
            }
            Console.WriteLine(nums[0]);
        }
    }
}
