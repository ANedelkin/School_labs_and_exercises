using System;
using System.Linq;

namespace _06._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int maxLength = 0, num = 0;
            for (int i = 0; i < nums.Length && maxLength < nums.Length - i; i++)
            {
                int length = 0;
                for (int j = i + 1; j < nums.Length && nums[i] == nums[j]; j++) { length++; }
                if (length > maxLength) { maxLength = length; num = nums[i]; }
            }
            for (int i = 0; i <= maxLength; i++) { Console.Write(num + " "); }
        }
    }
}
