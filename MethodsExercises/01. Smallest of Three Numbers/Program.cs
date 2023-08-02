using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Min(int.Parse(Console.ReadLine()), Math.Min(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()))));
        }
    }
}
