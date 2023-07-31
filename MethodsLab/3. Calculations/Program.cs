using System;

namespace _3._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Console.ReadLine(), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
        }
        static int? Calculate(string action, int a, int b)
        {
            switch (action)
            {
                case "add":
                    return a + b;
                case "substract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    return null;
            }
        }
    }
}
