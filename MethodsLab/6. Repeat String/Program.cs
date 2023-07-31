using System;

namespace _6._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(RepeatString(Console.ReadLine(), int.Parse(Console.ReadLine())));
        }
        static string RepeatString(string str, int times)
        {
            string output = string.Empty;
            for (int i = 0; i < times; i++) { output += str; }
            return output;
        }
    }
}
