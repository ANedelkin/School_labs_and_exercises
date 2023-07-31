using System;

namespace _5._Calculate_Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine()), h = double.Parse(Console.ReadLine());
            double area(double width, double height) => width * height;
            Console.WriteLine(area(w, h));
        }
    }
}
