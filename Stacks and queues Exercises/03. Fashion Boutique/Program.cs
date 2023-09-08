using System;
using System.Linq;
using System.Collections.Generic;

namespace _03._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] n = Console.ReadLine().Split(' ').Select(byte.Parse).ToArray();
            Stack<byte> clothes = new Stack<byte>();
            for (byte i = 0; i < n.Length; i++) { clothes.Push(n[i]); }
            byte racks = 1, rack = 0, cap = byte.Parse(Console.ReadLine());
            for (byte i = 0; i < n.Length; i++) 
            { 
                if (rack + clothes.Peek() < cap) { rack += clothes.Peek(); }
                else if (rack + clothes.Peek() == cap) { if (clothes.Count > 1) { racks++; rack = 0; } }
                else if (rack + clothes.Peek() > cap) { racks++; rack = clothes.Peek(); }
                clothes.Pop();
            }
            Console.WriteLine(racks);
        }
    }
}
