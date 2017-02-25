using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P182_Party_Planner
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetPartyOptions(5, this.fancyCheckBox.Checked);
            dinnerParty.SetHealthyOption(this.healthyCheckBox.Checked);
            dinnerParty.CalculateCostOfDecorations(this.fancyCheckBox.Checked);
            DisplayDinnerPartyCost();
            this.numericUpDown1.ValueChanged += (sender, e) =>
            {
                dinnerParty.SetPartyOptions((int)((NumericUpDown)sender).Value, this.fancyCheckBox.Checked);
                DisplayDinnerPartyCost();
            };
            this.fancyCheckBox.CheckStateChanged += (sender, e) =>
            {
                dinnerParty.CalculateCostOfDecorations(((CheckBox)sender).Checked);
                DisplayDinnerPartyCost();
            };

            this.healthyCheckBox.CheckStateChanged += (sender, e) =>
            {
                dinnerParty.SetHealthyOption(((CheckBox)sender).Checked);
                DisplayDinnerPartyCost();
            };
        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost();
            costLabel.Text = Cost.ToString("c");
        }


    }
}
