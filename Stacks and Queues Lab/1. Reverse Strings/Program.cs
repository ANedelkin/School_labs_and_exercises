using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> text = new Stack<char>();
            foreach (char item in input) { text.Push(item); }
            Console.WriteLine(string.Join("", text));
        }
    }
}
