using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gpax
{
    internal class GPAcalculator
    {
        private double gpa_sum;
        private double n;
        private double gpa_min = double.MaxValue;
        private double gpa_max = double.MinValue;
        private List<double> gpas = new List<double>();

        public void setGpa(double gpa)
        {
            this.gpa_sum += gpa;
            this.n++;
            gpas.Add(gpa);
            if (gpa < gpa_min)
            {
                gpa_min = gpa;
            }
            if (gpa > gpa_max)
            {
                gpa_max = gpa;
            }
        }

        public double getGpa()
        {
            return this.gpa_sum / this.n;
        }

        public double GetMaxGPA()
        {
            return gpa_max;
        }

        public double GetMinGPA()
        {
            return gpa_min;
        }
    }
}