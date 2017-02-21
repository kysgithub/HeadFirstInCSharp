using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P169_Labs_A_Day_at_the_Races
{
    class Greyhound
    {
        #region Fields
        public int StartingPosition;// Where my PictureBox starts
        public int RacetrackerLength;// How long the racetrack is
        public PictureBox MyPictureBox = null;// My PictureBox object
        public int Location = 0;// My Location on the racetrack
        public Random Randomizer;// An instance of Random
        #endregion

        #region Constructor
        public Greyhound()
        {
        }

        //public Greyhound(int startingposition, int racetrackerlength)
        //    : this()
        //{
        //    StartingPosition = startingposition;
        //    RacetrackerLength = racetrackerlength;
        //}

        //public Greyhound(PictureBox pb, Random rd, int startingposition, int racetrackerlength)
        //    : this()
        //{
        //    MyPictureBox = pb;
        //    Randomizer = rd;
        //    StartingPosition = startingposition;
        //    RacetrackerLength = racetrackerlength;
        //}
        #endregion

        public bool Run()
        {
            // Move forward either 1,2,3 or 4 spaces at random
            // Update the position of my picturebox on the form
            // Return true if I won the race
            return false;
        }

        public void TakeStartingPosition()
        {
            // Reset my location to the start line
        }
    }
}
