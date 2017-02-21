using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P169_Labs_A_Day_at_the_Races
{
    class Guy
    {
        #region Fields
        public string Name;// The guy's name
        public int MyBet;// An instance of Bet() that has his bet
        public int Cash;// How much cash he has

        // The last two fields are the guy's GUI controls on the form
        public RadioButton MyRadioButton;// My RadioButton
        public Label MyLabel;// My Label
        #endregion

        #region Constructor
        public Guy()
        {
        }
        #endregion

        public void UpdateLabels()
        {
            // Set my label to my bet's description, and the label on my
            // radio button to show my cash ("Joe has 43 bucks")
        }
        public bool PlaceBet(int Amount, int Dog)
        {
            bool result = false;
            // Place a new bet and store it in my bet field
            // Return true if the guy had enough money to bet
            return result;
        }
        public void ClearBet()
        {
            // Reset my bet so it's zero
        }
        public void Collect(int Winner)
        {
            // Ask my bet to pay out
        }
    }
}
