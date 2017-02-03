using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P135_Mile_Calculator
{
    public partial class Form1 : Form
    {
        int startingMileage, endingMileage;
        double mileTraveled, reimburseRate = 3.9, amountOwed;
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += (sender, e) =>
            {
                startingMileage = (int)numericUpDown1.Value;
                endingMileage = (int)numericUpDown2.Value;
                if (startingMileage < endingMileage)
                {
                    mileTraveled = endingMileage - startingMileage;
                    amountOwed = mileTraveled * reimburseRate;
                    label3.Text = "$" + amountOwed;
                }
                else
                {
                    MessageBox.Show("The starting mileage must be less than the ending mileage.", "Cannot Calculate");
                }
            };
            this.button2.Click += (sender, e) =>
            {
                MessageBox.Show(mileTraveled + " miles", "Miles Traveled");
            };
        }
    }
}
