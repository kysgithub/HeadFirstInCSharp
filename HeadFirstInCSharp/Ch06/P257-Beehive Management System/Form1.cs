using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace P257_Beehive_Management_System
{
    public partial class Form1 : Form
    {
        Queen queen;
        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" }, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing",
                "Egg care", "Baby bee tutoring", "Hive maintenance", "Sting patrol" }, 155);
            queen = new Queen(workers);
            this.assignJob.Click += (sender, e) =>
            {
                //if (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))
                //    MessageBox.Show("The job '" + workerBeeJob.Text + "' will be done in "
                //        + shifts.Value + " shifts", "The queen bee says...");
                //else
                //    MessageBox.Show("No workers are available to do the job '"
                //        + workerBeeJob.Text + "'", "The queen bee says...");
                // testky
                MessageBox.Show(String.Format(@"{0}", (queen.AssignWork(workerBeeJob.Text, (int)shifts.Value) ?
                    ("The job '" + workerBeeJob.Text + "' will be done in " + shifts.Value + " shifts")
                    : ("No workers are available to do the job '" + workerBeeJob.Text + "'"))),
                    "The queen bee says...");
            };


            this.nextShift.Click += (sender, e) =>
            {
                report.Text = queen.WorkTheNextShift();
            };
        }

    }
}
