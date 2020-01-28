using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw2a
{
    class HeightConverter
    {
        public decimal HeightConversion(int foot, decimal inch)
        {
            const int footToInch = 12;
            decimal totalInch = (footToInch * foot) + inch;
            return totalInch;
        }
    }
}
