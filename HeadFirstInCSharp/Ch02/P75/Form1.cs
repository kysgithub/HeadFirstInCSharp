using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P75
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Click += (sender, e) =>
            {
                if (this.checkBox1.Checked)
                {
                    this.label1.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    if (this.label1.BackColor == Color.Red)
                    {
                        this.label1.BackColor = Color.Blue;
                    }
                    else
                    {
                        this.label1.BackColor = Color.Red;
                    }
                }
                else
                {
                    this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                    MessageBox.Show("The box is not checked");
                }
            };
        }
    }
}
