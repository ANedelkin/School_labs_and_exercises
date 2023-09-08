using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int[]> stations = new Queue<int[]>();
            for (int i = 0; i < n; i++) { stations.Enqueue(Console.ReadLine().Split(' ').Select(int.Parse).ToArray()); }
            for (int i = 0; i < stations.Count; i++)
            {
                int fuel = 0;
                bool f = true;
                for (int j = 0; j < stations.Count; j++)
                {
                    int[] station = stations.Dequeue();
                    fuel += station[0] - station[1];
                    if (fuel < 0) { f = false; }
                    stations.Enqueue(station);
                }
                stations.Enqueue(stations.Dequeue());
                if (f) { Console.WriteLine(i); break; }
            }          
        }
    }
}
