using System;

namespace _1._Grades
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ToWords(double.Parse(Console.ReadLine())));
        }
        static string ToWords(double grade)
        {
            if (grade <= 2.99) { return "Fail"; }
            else if (grade <= 3.49) { return "Poor"; }
            else if (grade <= 4.49) { return "Good"; }
            else if (grade <= 5.49) { return "Very good"; }
            else { return "Excellent"; }
        }
    }
}
