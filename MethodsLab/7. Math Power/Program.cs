using System;

namespace _7._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(Power(num, power));
        }
        static double Power(double num, int power)
        {
            double n = 0;
            for (int i = 0; i < power; i++) { n *= num; }
            return n;
        }
    }
}
