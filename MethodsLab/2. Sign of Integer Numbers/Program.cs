using System;

namespace _2._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"The number {n} is {Sign(n)}.");
        }
        static string Sign(int num)
        {
            if (num > 0) { return "positive"; }
            else if (num < 0) { return "negative"; }
            else { return "zero"; }
        }
    }
}
