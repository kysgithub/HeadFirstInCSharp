using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P89
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += (send, e) =>
            {
                MessageBox.Show(String.Format(@"The message length is {0}",
                    Talker.BlahBlahBlah(this.textBox1.Text.Trim(),
                        Convert.ToInt16(this.numericUpDown1.Value))
                        )
                );
            };
        }
    }
}
