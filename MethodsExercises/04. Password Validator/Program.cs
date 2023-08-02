using System;
using System.Text.RegularExpressions;

namespace _04._Password_Validator
{
    class Program
    {
        static bool valid = true;
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            FitsInRange(input); ContainsSC(input); HasDigits(input);
            if (valid) { Console.WriteLine("Password is valid"); }
        }

        static void ContainsSC(string str)
        {
            Regex rgx = new Regex("[^A-Za-z0-9]");
            if (rgx.IsMatch(str)) { Console.WriteLine("Password must consist only of letters and digits"); valid = false; }
        }
        static void FitsInRange(string str)
        {
            if (str.Length > 10 || str.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters"); valid = false;
            }
        }
        static void HasDigits(string str)
        {
            Regex rgx = new Regex("[0-9]"); int count = 2;
            for (int i = 0; i < str.Length && count > 0; i++) { if (rgx.IsMatch(str[i].ToString())) { count--; } }
            if (count > 0) { Console.WriteLine("Password must have at least 2 digits"); valid = false; }
        }
    }
}