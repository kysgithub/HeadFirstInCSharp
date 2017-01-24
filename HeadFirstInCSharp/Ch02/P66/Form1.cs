using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P66
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += (sender, e) =>
            {
                string name = "Quentin";
                int x = 3;
                x *= 17;
                double d = Math.PI / 2;
                MessageBox.Show("name is " + name + "\nx is " + x + "\nd is " + d);
            };
            this.button2.Click += (sender, e) =>
            {
                int x = 5;
                if (x == 10)
                {
                    MessageBox.Show("x must be 10");
                }
                else
                {
                    MessageBox.Show("x isn't 10");
                }
            };
            this.button3.Click += (sender, e) =>
            {
                int someValue = 4;
                string name = "Bobbo Jr.";
                if ((someValue == 3) && (name == "Joe"))
                {
                    MessageBox.Show("x is 3 and the name is Joe");
                }
                MessageBox.Show("this line runs no matter what");
            };
            this.button4.Click += (sender, e) =>
            {
                int count = 0;
                while (count < 10)
                {
                    count++;
                }
                for (int i = 0; i < 5; i++)
                {
                    count--;
                }

                MessageBox.Show("The answer is " + count);
            };
            this.button5.Click += (sender, e) =>
            {
                string result = string.Empty;
                int x = 3;
                while (x > 0)
                {
                    if (x > 2)
                    {
                        result += "a";
                    }
                    x -= 1;
                    result += "-";
                    if (x == 2)
                    {
                        result += "b c";
                    }
                    if (x == 1)
                    {
                        result += "d";
                        x -= 1;
                    }
                }

                MessageBox.Show(result);
            };
        }
    }
}
