using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P218_Party_Planner_2
{
    class BirthdayParty
    {
        #region Field

        // public field
        public const int CostOfFoodPerPerson = 25;
        public decimal CostOfDecorations;
        public int CakeSize;

        // private field
        private int numberOfPeople;
        private bool fancyDecorations;
        private string cakeWriting = string.Empty;

        #endregion Field

        #region Properties
        public int NumberOfPeople
        {
            get { return this.numberOfPeople; }
            set
            {
                this.numberOfPeople = value;
                CalculateCostOfDecorations(this.fancyDecorations);
                CalculateCakeSize();
                CakeWriting = this.cakeWriting;
            }
        }

        public string CakeWriting
        {
            get
            {
                return this.cakeWriting;
            }
            set
            {
                int maxLength;
                maxLength = CakeSize == 8 ? 16 : 40;
                if (value.Length > maxLength)
                {
                    System.Windows.Forms.MessageBox.Show(
                        String.Format(@"Too many letters for a {0} inch cake", CakeSize));
                    // Intercept the input string if exceed the max length
                    this.cakeWriting = value.Substring(0, maxLength);
                }
                else
                {
                    this.cakeWriting = value;
                }
            }
        }
        #endregion

        #region Constructor
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            CalculateCakeSize();
            this.cakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }
        #endregion


        #region Private Function
        private void CalculateCakeSize()
        {
            CakeSize = this.numberOfPeople <= 4 ? 8 : 16;
        }
        #endregion Private Function

        #region Public Function
        public decimal CalculateCost()
        {
            decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            decimal CakeCost;
            CakeCost = (CakeSize == 8 ? 40m : 75m) + CakeWriting.Length * .25m;
            return TotalCost + CakeCost;
        }

        public void CalculateCostOfDecorations(bool fancyDecorations)
        {
            CostOfDecorations = fancyDecorations ? (NumberOfPeople * 15m) + 50m : (NumberOfPeople * 7.5m) + 30m + NumberOfPeople > 12 ? 100 : 0;
        }

        #endregion
    }
}
