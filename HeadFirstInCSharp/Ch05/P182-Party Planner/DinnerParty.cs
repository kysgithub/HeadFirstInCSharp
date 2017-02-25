using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P182_Party_Planner
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;
        private int numberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations;
        bool HealthyOption;

        public void SetPartyOptions(int people, bool fancy)
        {
            numberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return numberOfPeople;
        }

        public void SetHealthyOption(bool healthyOption)
        {
            CostOfBeveragesPerPerson = (this.HealthyOption = healthyOption) ? 5m : 20m;
        }

        public void CalculateCostOfDecorations(bool fancyDecoration)
        {
            CostOfDecorations = fancyDecoration ? (decimal)(numberOfPeople * 15m + 50m) : (decimal)(numberOfPeople * 7.5m + 30m);
        }

        public decimal CalculateCost()
        {
            return (numberOfPeople * (CostOfFoodPerPerson + CostOfBeveragesPerPerson) + CostOfDecorations) * (decimal)(HealthyOption ? (1m - .05m) : 1m);
        }
    }
}
