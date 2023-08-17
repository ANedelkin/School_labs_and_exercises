using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] ns = nums.ToArray();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "end")
            {
                switch (command[0])
                {
                    case "Add":
                        nums.Add(int.Parse(command[1]));
                        break;
                    case "Remove":
                        nums.Remove(int.Parse(command[1]));
                        break;
                    case "RemoveAt":
                        nums.RemoveAt(int.Parse(command[1]));
                        break;
                    case "Insert":
                        nums.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                    case "Contains":
                        Console.WriteLine(Contains2(nums, int.Parse(command[1])));
                        break;
                    case "PrintEven":
                        Console.WriteLine(string.Join(' ', nums.FindAll(n => n % 2 == 0)));
                        break;
                    case "PrintOdd":
                        Console.WriteLine(string.Join(' ', nums.FindAll(n => n % 2 != 0)));
                        break;
                    case "GetSum":
                        Console.WriteLine(GetSum(nums));
                        break;
                    case "Filter":
                        Console.WriteLine(string.Join(' ', Filter(nums, command[1], int.Parse(command[2]))));
                        break;

                }
                command = Console.ReadLine().Split(' ').ToArray();
            }
            if (string.Join(' ',ns) != string.Join(' ', nums)) { Console.Write(string.Join(' ', nums)); }
        }
        static string Contains2(List<int> list, int num)
        {
            if (list.Contains(num)) { return "Yes"; }
            else { return "No such number"; }
        }
        static int GetSum(List<int> list)
        {
            int sum = 0;
            foreach (int i in list) { sum += i; }
            return sum;
        }
        static List<int> Filter(List<int> list, string con, int num)
        {
            switch (con)
            {
                case "<":
                    return list.FindAll(n => n < num);
                case ">":
                    return list.FindAll(n => n > num);
                case "<=":
                    return list.FindAll(n => n <= num);
                case ">=":
                    return list.FindAll(n => n >= num);
                default:
                    return null;
            }
        }
    }
}
