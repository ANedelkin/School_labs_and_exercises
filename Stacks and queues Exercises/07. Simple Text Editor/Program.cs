using System;
using System.Linq;
using System.Collections.Generic;

namespace _07._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> history = new Stack<string>();
            history.Push("");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(' ');
                switch (command[0])
                {
                    case "1":
                        history.Push(history.Peek() + command[1]);
                        break;
                    case "2":
                        string str = history.Peek();
                        int range = int.Parse(command[1]);
                        history.Push(str.Remove(str.Length - range, range));
                        break;
                    case "3":
                        Console.WriteLine(history.Peek()[int.Parse(command[1]) - 1]);
                        break;
                    case "4":
                        history.Pop();
                        break;
                }
            }
        }
    }
}
