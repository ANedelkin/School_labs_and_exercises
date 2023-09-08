using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool f = true;
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>();
            for (int i = 0; i < input.Length; i++) { songs.Enqueue(input[i]); }
            while (songs.Count > 0)
            {
                List<string> command = Console.ReadLine().Split(' ').ToList();
                switch (command[0])
                {
                    case "Add":
                        command.RemoveAt(0); ;
                        if (!songs.Contains(string.Join(' ', command))) { songs.Enqueue(string.Join(' ', command)); }
                        else { Console.WriteLine(string.Join(' ', command) + " is already contained!"); }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    case "Play":
                        songs.Dequeue();
                        break;
                    default:
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
