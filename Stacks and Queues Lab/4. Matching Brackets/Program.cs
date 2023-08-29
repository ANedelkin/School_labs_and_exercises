using System;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<int> openBrackets = new Stack<int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(') { openBrackets.Push(i); }
                else if (input[i] == ')')
                {
                    for (int j = openBrackets.Pop(); j <= i; j++)
                    {
                        Console.Write(input[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
