using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int c = 0;
            string input = Console.ReadLine().ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < vowels.Length; j++)
                {
                    if (input[i] == vowels[j]) { c++; }
                }
            }
            Console.Write(c);
        }
    }
}
