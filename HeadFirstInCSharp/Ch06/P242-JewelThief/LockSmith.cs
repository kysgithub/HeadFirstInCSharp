using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P242_JewelThief
{
    class LockSmith
    {
        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writtenDownCombination);
            ReturnContents(safeContents, owner);
            LockSmith thief = new JewelThief();
            ////JewelThief thief = new JewelThief();
            //thief.ReturnContents(safeContents, owner);
        }

        private string writtenDownCombination = null;
        public void WriteDownCombination(string combination)
        {
            writtenDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveContents(safeContents);
        }
    }
}
