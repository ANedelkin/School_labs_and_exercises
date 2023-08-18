using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> sbn = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < nums.FindAll(n => n == sbn[0]).Count; i++)
            {
                for (int j = 0; j < nums.Count; j++)
                {
                    if (nums[j] == sbn[0]) 
                    { 
                        RemoveWithNeighbors(nums, j, sbn[1]);
                        j = 0;
                    }
                }
            }
            Console.WriteLine(Sum(nums));
        }
        static void RemoveWithNeighbors(List<int> list, int index, int range)
        {
            for (int i = 0; i < range && index + 1 < list.Count; i++) 
            {
                if (index + range + 1 < list.Count && list[index] == list[index + range + 1]) 
                { 
                    break; 
                }
                list.RemoveAt(index + 1);
            }
            for (int i = 0; i < range && index > 0; i++)
            {
                list.RemoveAt(index - 1); 
                index--;
            }
            list.RemoveAt(index);
        }
        static int Sum(List<int> list)
        {
            int sum = 0;
            foreach (int i in list) { sum += i; }
            return sum;
        }
    }
}
