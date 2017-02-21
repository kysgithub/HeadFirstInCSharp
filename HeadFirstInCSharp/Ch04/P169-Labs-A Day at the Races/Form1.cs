using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P169_Labs_A_Day_at_the_Races
{
    public partial class Form1 : Form
    {
        Guy[] guys;
        Greyhound[] hounds;

        public Form1()
        {
            InitializeComponent();
            Initialize();
        }

        public void Initialize()
        {
            guys = new Guy[3];
            guys[0] = new Guy() { Name = "Joe" };
            guys[1] = new Guy() { Name = "Bob" };
            guys[2] = new Guy() { Name = "Al" };

            hounds = new Greyhound[4];
            hounds[0] = new Greyhound() { };
            hounds[1] = new Greyhound() { };
            hounds[2] = new Greyhound() { };
            hounds[3] = new Greyhound() { };
        }
    }
}
