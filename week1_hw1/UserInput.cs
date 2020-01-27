using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace week1_hw1
{
    class UserInput
    {
        public int Input()
        {
            int intAge = 0;
            
            // Loop till the user enters a valid input
            do
            {
                Console.WriteLine("What is your expected starting working age? Please enter an integer that is greater than or equal to 16.");
            } while (!int.TryParse(Console.ReadLine(), out intAge) || (intAge < 16));

            return intAge;
        }
    }
}
