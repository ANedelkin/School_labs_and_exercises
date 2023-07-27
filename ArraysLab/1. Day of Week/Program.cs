using System;

namespace _1._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            try { Console.WriteLine(days[int.Parse(Console.ReadLine()) - 1]); }
            catch (IndexOutOfRangeException) { Console.WriteLine("Invalid day!"); }
        }
    }
}
