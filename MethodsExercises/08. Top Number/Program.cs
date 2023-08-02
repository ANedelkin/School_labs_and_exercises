using System;

namespace _08._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) { CheckNum(i); }
        }
        static void CheckNum(int num)
        {
            int sum = 0, tnum = num;
            bool f = false;
            while(tnum > 0)
            {
                if ((tnum % 10) % 2 != 0) { f = true; }
                sum += tnum % 10;
                tnum /= 10;
            }
            if (f && sum % 8 == 0) { Console.WriteLine(num); }
        }
    }
}
