using System;
using System.Linq;
using System.Collections.Generic;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            List<string> command = Console.ReadLine().Split(' ').ToList();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        wagons.Add(int.Parse(command[1]));
                        break;
                    default:
                        PutIn(wagons, int.Parse(command[0]), max);
                        break;
                }
                command = Console.ReadLine().Split(' ').ToList();
            }
            Console.WriteLine(string.Join(' ', wagons));
        }
        static void PutIn(List<int> list, int n, int m)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] + n <= m) 
                { 
                    list[i] += n;
                    break;
                }
            }
        }
    }
}
