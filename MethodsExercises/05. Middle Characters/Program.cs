using System;

namespace _05._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input.Length % 2 == 0) { Console.Write(input[input.Length / 2 - 1]); Console.Write(input[input.Length / 2]); }
            else { Console.Write(input[input.Length / 2]); }
        }
    }
}
