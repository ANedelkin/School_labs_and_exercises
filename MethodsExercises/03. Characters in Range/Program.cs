using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int char1 = Console.ReadLine()[0], char2 = Console.ReadLine()[0];
            for (int i = Math.Min(char1, char2) + 1; i < Math.Max(char1, char2); i++) { Console.Write((char)i + " "); }
        }
    }
}
