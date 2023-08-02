using System;

namespace _06._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), e = int.Parse(Console.ReadLine());
            int b = Math.Max(a, e); e = Math.Min(a, e);
            double result = 1;
            for (; b > e; b--) { result *= b; }
            if (e == a) { result = 1 /  result; }
            Console.WriteLine($"{result:F2}");
        }
    }
}
