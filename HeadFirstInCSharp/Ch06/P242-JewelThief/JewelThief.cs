using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P242_JewelThief
{
    class JewelThief : LockSmith
    {
        private Jewels stolenJewels = null;
        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            Console.WriteLine("I'm stealing the contents! " + stolenJewels.Sparkle());
        }
    }
}
