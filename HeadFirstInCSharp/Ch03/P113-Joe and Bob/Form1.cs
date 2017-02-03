using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P113_Joe_and_Bob
{
    public partial class Form1 : Form
    {
        Guy joe, bob;
        int bank = 100;
        public Form1()
        {
            InitializeComponent();
            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;

            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            UpdateForm();

            this.button1.Click += (sender, e) =>
            {
                if (bank >= 10)
                {
                    bank -= joe.ReceiveCash(10);
                    UpdateForm();
                }
                else
                {
                    MessageBox.Show("The bank is out of money.");
                }
            };
            this.button2.Click += (sender, e) =>
            {
                bank += bob.GiveCash(5);
                UpdateForm();
            };
            this.joeGivesToBob.Click += (sender, e) =>
            {
                bob.ReceiveCash(joe.GiveCash(10));
                UpdateForm();
            };
            this.bobGivesToJoe.Click += (sender, e) =>
            {
                joe.ReceiveCash(bob.GiveCash(5));
                UpdateForm();
            };
        }

        void UpdateForm()
        {
            joeCashlabel.Text = string.Format(@"{0} has ${1}.", joe.Name, joe.Cash);
            bobCashlabel.Text = string.Format(@"{0} has ${1}.", bob.Name, bob.Cash);
            bankCashlabel.Text = string.Format(@"The bank has ${0}.", bank);
        }
    }
}
