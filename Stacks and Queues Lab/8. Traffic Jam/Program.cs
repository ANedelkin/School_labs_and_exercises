using System;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()), passedCars = 0;
            Queue<string> cars = new Queue<string>();
            string command = Console.ReadLine();
            bool f = true;
            while (command != "end")
            {
                int l = Math.Min(n, cars.Count);
                if (command == "green")
                {
                    for (int i = 0; i < l; i++) { Console.WriteLine(cars.Dequeue() + " passed!"); passedCars++; }
                    f = false;
                }
                else
                {
                    cars.Enqueue(command);
                    if (f && cars.Count == n)
                    {
                        for (int i = 0; i < l; i++) { Console.WriteLine(cars.Dequeue() + " passed!"); passedCars++; }
                        f = false;
                    }
                }
                command = Console.ReadLine();
            }
            Console.Write(passedCars + " cars passed the crossroads.");
        }
    }
}
