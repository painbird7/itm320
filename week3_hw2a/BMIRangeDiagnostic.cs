using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3_hw2a
{
    class BMIRangeDiagnostic
    {
        public string DetermineBMIDiagnosis(double bmi)
        {
            string result;
            if (bmi < 18.5)
            {
                result = "clinically Underweight.";
            }
            else if (bmi >= 18.50 && bmi <=24.99)
            {
                result = "normal Weight.";
            }
            else if (bmi >= 25 && bmi <= 29.99)
            {
                result = "clinically overweight.";
            }
            else
            {
                result = "clinically Obese.";
            }
            return result;
        }
    }
}
