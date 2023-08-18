using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            while (first.Count > 0 && second.Count > 0)
            {
                if (first[0] > second[0])
                {
                    first.Add(first[0]);
                    first.Add(second[0]);
                }
                else if (first[0] < second[0])
                {
                    second.Add(second[0]);
                    second.Add(first[0]);
                }
                first.RemoveAt(0);
                second.RemoveAt(0);
            }
            if (second.Count == 0) { Console.WriteLine("First player wins! Sum: " + Sum(first)); }
            else { Console.WriteLine("Second player wins! Sum: " + Sum(second)); }
        }
        static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int i in list) { sum += i; }
            return sum;
        }
    }
}
