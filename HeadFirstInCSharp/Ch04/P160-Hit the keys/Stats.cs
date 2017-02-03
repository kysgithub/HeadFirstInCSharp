using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P160_Hit_the_keys
{
    class Stats
    {
        public int Total = 0, Missed = 0, Correct = 0, Accuracy = 0;
        public void Update(bool correctKey)
        {
            Total++;
            if (!correctKey)
            {
                Missed++;
            }
            else
            {
                Correct++;
            }

            Accuracy = (Correct / Total) * 100;
        }
    }
}
