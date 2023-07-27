using System;
using System.Linq;

namespace _3._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();
            foreach (double num in nums) { Console.WriteLine($"{Convert.ToDecimal(num)} => {Convert.ToDecimal(Math.Round(num, MidpointRounding.AwayFromZero))}"); }
        }
    }
}
