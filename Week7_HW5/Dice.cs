using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_HW5
{
    public class Dice
    {
        public int Roll(int min, int max)
        {
            Random random = new Random();
            int rollNumber = random.Next(min, max);
            return rollNumber;
        }
    }
}
