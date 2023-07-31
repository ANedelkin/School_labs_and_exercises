using System;

namespace _10._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate(int.Parse(Console.ReadLine()), Console.ReadLine()[0], int.Parse(Console.ReadLine())));
            
        }
        static int? Calculate(int n1, char operation, int n2)
        {
            switch (operation)
            {
                case '/':
                    return n1 / n2;
                case '*':
                    return n1 * n2;
                case '+':
                    return n1 + n2;
                case '-':
                    return n1 - n2;
                default:
                    return null;
            }
        }
    }
}
