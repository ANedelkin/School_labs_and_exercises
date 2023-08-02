using System;

namespace _07._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
                bool f = true;
                for (int i = 0; i < input.Length / 2 && f; i++)
                {
                    if (input[i] != input[input.Length - i - 1]) { f = false; }
                }
                Console.WriteLine(f);
                input = Console.ReadLine();
            }
        }
    }
}
