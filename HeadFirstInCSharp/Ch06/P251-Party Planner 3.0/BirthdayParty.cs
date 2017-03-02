using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P251_Party_Planner_3
{
    class BirthdayParty : Party
    {
        #region Field
        // public field
        public int CakeSize;

        // private field
        private string cakeWriting = string.Empty;
        #endregion Field

        #region Properties
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

        public override int NumberOfPeople
        {
            get
            {
                return base.NumberOfPeople;
            }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                CakeWriting = cakeWriting;
            }
        }
        #endregion

        #region Constructor
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            //CalculateCostOfDecorations(fancyDecorations);
        }
        #endregion


        #region Private Function
        private void CalculateCakeSize()
        {
            CakeSize = NumberOfPeople <= 4 ? 8 : 16;
        }
        #endregion Private Function

        #region Public Function
        public override decimal CalculateCost()
        {
            //decimal TotalCost = CostOfDecorations + (CostOfFoodPerPerson * NumberOfPeople);
            //decimal CakeCost;
            //CakeCost = (CakeSize == 8 ? 40m : 75m) + CakeWriting.Length * .25m;
            return base.CalculateCost() + (CakeWriting.Length * .25m) + (CakeSize == 8 ? 40m : 75m);
        }

        #endregion
    }
}
