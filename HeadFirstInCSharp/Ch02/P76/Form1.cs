using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P76
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += (sender, evt) =>
            {
                while (Visible)
                {
                    for (int c = 0; c < 254 && Visible; c++)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    }
                    System.Threading.Thread.Sleep(300);
                    for (int c = 254; c >= 0 && Visible; c--)
                    {
                        this.BackColor = Color.FromArgb(c, 255 - c, c);
                        Application.DoEvents();
                        System.Threading.Thread.Sleep(3);
                    }
                    System.Threading.Thread.Sleep(300);
                }
            };

            int x = 0;
            string poem = "";
            while (x < 4)
            {
                poem += "a";
                if (x < 1)
                {
                    poem += " ";
                }
                poem += "n";
                if (x > 1)
                {
                    poem += " oyster";
                    x += 2;
                }
                if (x == 1)
                {
                    poem += "noys ";
                }
                if (x < 1)
                {
                    poem += "oise ";
                }
                x++;
            }
            MessageBox.Show(poem);
        }

    }

}
