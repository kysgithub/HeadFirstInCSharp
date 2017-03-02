using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P242_JewelThief
{
    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";

        public Jewels Open(string combination)
        {
            return combination == safeCombination ? contents : null;
        }

        public void PickLock(LockSmith lockpicker)
        {
            lockpicker.WriteDownCombination(safeCombination);
        }
    }
}
