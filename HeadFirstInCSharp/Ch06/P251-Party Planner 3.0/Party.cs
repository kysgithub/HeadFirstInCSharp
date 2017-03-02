using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P251_Party_Planner_3
{
    class Party
    {
        private const decimal CostOfFoodPerPerson = 25m;
        private bool fancyDecorations = false;
        public bool FancyDecorations
        {
            get { return fancyDecorations; }
            set
            {
                fancyDecorations = value;
                CalculateCostOfDecorations(FancyDecorations);
            }
        }

        private int numberOfPeople = 0;
        public virtual int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(FancyDecorations);
            }
        }

        private decimal costOfDecorations = 0m;
        public decimal CostOfDecorations
        {
            get { return costOfDecorations; }
            private set { costOfDecorations = value; }
        }

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }

        public virtual void CalculateCostOfDecorations(bool fancyDecorations)
        {
            this.fancyDecorations = fancyDecorations;
            CostOfDecorations = fancyDecorations ? ((NumberOfPeople * 15m) + 50m) : ((NumberOfPeople * 7.5m) + 30m);
        }

        public virtual decimal CalculateCost()
        {
            return CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople) + (NumberOfPeople > 12 ? 100m : 0m);
        }
    }
}
