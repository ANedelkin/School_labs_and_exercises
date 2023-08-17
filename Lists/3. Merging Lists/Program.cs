using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> nums1 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            List<double> nums2 = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            for (int i = 0; i < Math.Max(nums1.Count, nums2.Count); i++)
            {
                if (i < nums1.Count ) { Console.Write(nums1[i] + " "); } 
                if (i < nums2.Count) { Console.Write(nums2[i] + " "); }
            }
        }
    }
}
