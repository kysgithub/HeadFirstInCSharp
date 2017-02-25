using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P204_Cow_Calculator
{
    public partial class Form1 : Form
    {

        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
            this.numericUpDown1.ValueChanged += (sender, e) =>
            {
                farmer.NumberOfCows = (int)(sender as NumericUpDown).Value;
            };
            this.button1.Click += (sender, e) =>
            {
                Console.WriteLine("I need {0} bags of feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
            };
        }
    }
}
