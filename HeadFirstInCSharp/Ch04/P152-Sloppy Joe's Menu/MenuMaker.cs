using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P152_Sloppy_Joe_s_Menu
{
    class MenuMaker
    {
        public MenuMaker() { }
        public Random Randomizer;
        string[] Meats = { "Roast beef", "Salami", "Turkey", "Ham", "Pastrami" };
        string[] Condiments = { "yellow mustard", "brown mustard", "honey mustard", "mayo", "relish", "french dressing" };
        string[] Breads = { "rye", "white", "wheat", "pumpernickel", "italian bread", "a roll" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiment = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBread = Breads[Randomizer.Next(Breads.Length)];
            return String.Format(@"{0} with {1} on {2}", randomMeat, randomCondiment, randomBread);
        }
    }
}
