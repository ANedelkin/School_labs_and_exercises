using System;

namespace _4._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            printPiramid(int.Parse(Console.ReadLine()));
        }
        static void printPiramid(int n)
        {
            int dir = 1;
            for (int i = 1; i > 0; i += dir)
            {
                for (int j = 1; j <= i; j++) { Console.Write(j + " "); }
                Console.WriteLine();
                if (i == n) { dir = -1; }
            }
        }
    }
}
