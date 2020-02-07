using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw2a
{
    class HeightConverter
    {
        public double HeightConversion(int foot, double inch)
        {
            const int footToInch = 12;
            double totalInch = (footToInch * foot) + inch;
            return totalInch;
        }
    }
}
