using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P251_Party_Planner_3
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        bool HealthyOption;

        public DinnerParty(int numberOfPeople, bool fancyDecorations, bool healthyOption)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = (this.HealthyOption = healthyOption) ? 5m : 20m;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            return (base.CalculateCost() + (CostOfBeveragesPerPerson * NumberOfPeople))
                * (healthyOption ? .95m : 1m);
        }

    }
}
