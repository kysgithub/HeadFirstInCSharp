using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P160_Hit_the_keys
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        string test = "test ignorelist";
        public Form1()
        {
            InitializeComponent();
            this.timer1.Interval = 800;
            this.timer1.Start();
            this.timer1.Tick += (sender, e) =>
            {
                // Add a random key to the ListBox
                listBox1.Items.Add((Keys)random.Next(65, 90));
                if (listBox1.Items.Count > 7)
                {
                    listBox1.Items.Clear();
                    listBox1.Items.Add("Game Over");
                    timer1.Stop();
                }
            };

            this.listBox1.KeyDown += (sender, e) =>
            {
                if (this.listBox1.Items.Contains(e.KeyCode))
                {
                    listBox1.Items.Remove(e.KeyCode);
                    listBox1.Refresh();
                    if (timer1.Interval > 400)
                        timer1.Interval -= 10;
                    if (timer1.Interval > 250)
                        timer1.Interval -= 7;
                    if (timer1.Interval > 100)
                        timer1.Interval -= 2;
                    int diffculty = 800 - timer1.Interval;
                    if (diffculty >= 100)
                    {
                        difficultyProgreeBar.Value = 100;
                        listBox1.Items.Clear();
                        listBox1.Items.Add("爆机");
                        timer1.Stop();
                        return;
                    }
                    else
                    {
                        difficultyProgreeBar.Value = 800 - timer1.Interval;
                    }
                    stats.Update(true);
                }
                else
                {
                    stats.Update(false);
                }

                correctLabel.Text = "Correct: " + stats.Correct;
                missedLabel.Text = "Missed: " + stats.Missed;
                totalLabel.Text = "Total: " + stats.Total;
                accuracyLabel.Text = "Accuracy: " + stats.Accuracy + "%";
            };
        }
    }
}
