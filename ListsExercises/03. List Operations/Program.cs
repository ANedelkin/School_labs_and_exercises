using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "End")
            {
                try
                {
                    switch (command[0])
                    {
                        case "Add":
                            nums.Add(int.Parse(command[1]));
                            break;
                        case "Remove":
                            nums.RemoveAt(int.Parse(command[1]));
                            break;
                        case "Insert":
                            nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                            break;
                        case "Shift":
                            Shift(nums, command[1], int.Parse(command[2]));
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException) { Console.WriteLine("Invalid index"); }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.Write(string.Join(' ', nums));
        }
        static void Shift(List<int> list, string dir, int times)
        {
            if (dir == "left")
            {
                for (int i = 0; i < times; i++)
                {
                    list.Add(list[0]);
                    list.RemoveAt(0);
                }
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    int lNum = list[list.Count - 1];
                    for (int j = list.Count - 1; j > 0; j--) { list[j] = list[j - 1]; }
                    list[0] = lNum;
                }
            }
        }
    }
}
