using System;

namespace _8._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    Console.WriteLine(Math.Max(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));
                    break; 
                case "char":
                    Console.WriteLine((Char)Math.Max(Console.ReadLine()[0], Console.ReadLine()[0]));
                    break;
                case "string":
                    Console.WriteLine(BiggerValueString(Console.ReadLine(), Console.ReadLine()));
                    break;
                default:
                    break;
            }
        }
        static string BiggerValueString(string a, string b)
        {
            if (string.Compare(a, b) == 0) { return a; }
            else { return b; }
        }
    }
}
