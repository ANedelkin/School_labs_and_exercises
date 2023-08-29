using System;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Stack<string> stack = new Stack<string>();
            foreach (string item in input) { stack.Push(item); }
            int result = int.Parse(input[0]);
            for (int i = 1; i < stack.Count - 1;)
            {
                int num = int.Parse(stack.Pop());
                if (stack.Pop() == "+") { result += num; }
                else { result -= num; }
            }
            Console.Write(result);
        }
    }
}
