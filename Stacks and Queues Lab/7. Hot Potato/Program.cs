using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            Queue<string> names = new Queue<string>();
            foreach (string item in input) { names.Enqueue(item); }
            int n = int.Parse(Console.ReadLine());
            while (names.Count > 1)
            {
                for (int j = 1; j < n; j++) { names.Enqueue(names.Dequeue()); }
                Console.WriteLine("Removed " + names.Dequeue());
            }
            Console.WriteLine("Last is " + names.Dequeue());
        }
    }
}
