using System;
using System.Linq;

namespace _02._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] fNums = new int[n], sNums = new int[n];
            for (int i = 0; i < n; i++)
            {
                int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                fNums[i] = nums[i % 2]; sNums[i] = nums[1 - i % 2];
            }
            Console.WriteLine(string.Join(' ', fNums));
            Console.Write(string.Join(' ', sNums));
        }
    }
}
