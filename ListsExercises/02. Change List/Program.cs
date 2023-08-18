using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Delete":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.Write(string.Join(' ', nums));
        }
    }
}
