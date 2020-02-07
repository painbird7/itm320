using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw2a
{
    class BMICalculator
    {
        public double CalculateBMI(double height, double weight)
        {
            double bmi = 703 * (weight / (Math.Pow(height, 2)));
            return bmi;
        }
    }
}
