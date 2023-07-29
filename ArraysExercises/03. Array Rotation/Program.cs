using System;
using System.Linq;
//using System.Collections.Generic;

namespace _03._Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            //int n = int.Parse(Console.ReadLine());
            //while (n >= nums.Count) { n -= nums.Count; }
            //for (int i = 0; i < n; i++) { nums.Add(nums[0]); nums.RemoveAt(0); }
            //Console.Write(string.Join(' ', nums));
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(), output = new int[nums.Length];
            int n = int.Parse(Console.ReadLine());
            while (n >= nums.Length) { n -= nums.Length; }
            for (int i = 0; i < n; i++) { output[nums.Length - n + i] = nums[i]; }
            for (int i = 0; i < nums.Length - n; i++) { output[i] = nums[i + n]; }
            Console.WriteLine(string.Join(' ', output)); 

            //int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            //int n = int.Parse(Console.ReadLine()); 
            //while (n >= nums.Length) { n -= nums.Length; }
            //int[] tNums = new int[n];
            //for (int i = 0; i < n; i++) { tNums[i] = nums[i]; }
            //for (int i = 0; i < nums.Length - n; i++) { nums[i] = nums[i + n]; }
            //for (int i = nums.Length - n; i < nums.Length; i++) { nums[i] = tNums[i - (nums.Length - n)]; } 
            //Console.WriteLine(string.Join(' ', nums));
        }
    }
}
