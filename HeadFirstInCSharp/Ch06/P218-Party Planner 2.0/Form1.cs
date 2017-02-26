using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P218_Party_Planner_2
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            //dinnerParty = new DinnerParty();
            //dinnerParty.SetPartyOptions(5, this.dinnerFancyDecorations.Checked);
            //dinnerParty.SetHealthyOption(this.dinnerHealthy.Checked);
            //dinnerParty.CalculateCostOfDecorations(this.dinnerFancyDecorations.Checked);
            //DisplayDinnerPartyCost();
            dinnerParty = new DinnerParty((int)dinnerPeople.Value, dinnerHealthy.Checked, dinnerFancyDecorations.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)birthdayPeople.Value, birthdayFancyDecorations.Checked, birthdayCakeWriting.Text.Trim());
            DisplayBirthdayPartyCost();

            this.dinnerPeople.ValueChanged += (sender, e) =>
            {
                dinnerParty.SetPartyOptions((int)((NumericUpDown)sender).Value, this.dinnerFancyDecorations.Checked);
                DisplayDinnerPartyCost();
            };
            this.dinnerFancyDecorations.CheckStateChanged += (sender, e) =>
            {
                dinnerParty.CalculateCostOfDecorations(((CheckBox)sender).Checked);
                DisplayDinnerPartyCost();
            };

            this.dinnerHealthy.CheckStateChanged += (sender, e) =>
            {
                dinnerParty.SetHealthyOption(((CheckBox)sender).Checked);
                DisplayDinnerPartyCost();
            };
            //////////////////////////////////////////////////////////////////////
            this.birthdayPeople.ValueChanged += (sender, e) =>
            {
                birthdayParty.NumberOfPeople = (int)((NumericUpDown)sender).Value;
                birthdayParty.CalculateCostOfDecorations(birthdayFancyDecorations.Checked);
                DisplayBirthdayPartyCost();
            };
            this.birthdayFancyDecorations.CheckStateChanged += (sender, e) =>
            {
                birthdayParty.CalculateCostOfDecorations(((CheckBox)sender).Checked);
                DisplayBirthdayPartyCost();
            };
            this.birthdayCakeWriting.TextChanged += (sender, e) =>
            {
                birthdayParty.CakeWriting = ((TextBox)sender).Text;
                DisplayBirthdayPartyCost();
            };

        }

        public void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost();
            dinnerCost.Text = Cost.ToString("c");
        }


        public void DisplayBirthdayPartyCost()
        {
            decimal Cost = birthdayParty.CalculateCost();
            birthdayCost.Text = Cost.ToString("c");
        }
    }
}
