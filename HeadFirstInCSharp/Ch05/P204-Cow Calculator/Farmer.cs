using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P204_Cow_Calculator
{
    class Farmer
    {
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumberOfCows = numberOfCows;
        }
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;

        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }

    }
}
