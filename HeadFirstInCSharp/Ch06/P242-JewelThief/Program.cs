using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P242_JewelThief
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief jewelThief = new JewelThief();
            jewelThief.OpenSafe(safe, owner);
            Console.ReadKey();
        }
    }
}
