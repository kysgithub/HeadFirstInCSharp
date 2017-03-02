using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P257_Beehive_Management_System
{
    class Bee
    {
        private double weight;
        public Bee(double weight)
        {
            this.weight = weight;
        }
        public virtual int ShiftsLeft
        {
            get { return 0; }
        }
        public virtual double GetHoneyConsumption()
        {
            return (ShiftsLeft == 0 ? 7.5 : 9 + ShiftsLeft) * (this.weight > 150 ? 1.35 : 1);
        }
    }
}
