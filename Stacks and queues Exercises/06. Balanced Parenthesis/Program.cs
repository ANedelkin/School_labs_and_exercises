using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> brackets = new Stack<char>();
            bool f = true;
            for (int i = 0; i < input.Length && f; i++)
            {
                try
                {
                    if (input[i] == ')')
                    {
                        if (!(brackets.Pop() == '(')) { f = false; }
                    }
                    else if (input[i] == ']')
                    {
                        if (!(brackets.Pop() == '[')) { f = false; }
                    }
                    else if (input[i] == '}')
                    {
                        if (!(brackets.Pop() == '{')) { f = false; }
                    }
                    else { brackets.Push(input[i]); }
                }
                catch (InvalidOperationException){ f = false; }
            }
            if (f) { Console.WriteLine("YES"); }
            else { Console.WriteLine("NO"); }
        }
    }
}
