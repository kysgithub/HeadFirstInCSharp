using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P147_Swap
{
    public partial class Form1 : Form
    {
        Elephant lucinda, lloyd;

        public Form1()
        {
            InitializeComponent();
            lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            this.button2.Click += (sender, e) =>
            {
                lloyd.WhoAmI();
            };
            this.button1.Click += (sender, e) =>
            {
                lucinda.WhoAmI();
            };
            this.button4.Click += (sender, e) =>
            {
                Elephant tmp = lucinda;
                lucinda = lloyd;
                lloyd = tmp;
                MessageBox.Show("Objects swapped");
            };
            this.button3.Click += (sender, e) =>
            {
                lloyd.TellMe("Hi", lucinda);
                lloyd.SpeakTo(lucinda, "Hello");
                lloyd = lucinda;
                lloyd.EarSize = 4321;
                lloyd.WhoAmI();
            };
        }
    }
}
