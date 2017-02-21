using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P169_Labs_A_Day_at_the_Races
{
    class Bet
    {
        #region Fields
        public int Amount;// The amount of cash that was bet
        public int Dog;// The number of the dog the bet is on
        public Guy Bettor;// The guy who palced the bet
        #endregion

        #region Constructor
        public Bet()
        {
        }
        #endregion

        public string GetDescription()
        {
            // Return a string that says who palced the bet , how much
            // cash was bet, and which dog he bet on ("Joe bets 8 on
            // dog #4"). If the amount is zero , no bet was palced ("
            // Joe hasn't palced a bet").
            return string.Empty;
        }
        public int PayOut(int Winner)
        {
            // The parameter is the winner of the race. If the dog won,
            // return the amount bet. Otherwise, return the negative of
            // the amount bet.
            return 0;
        }
    }
}
