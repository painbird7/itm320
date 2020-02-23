using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("This is child");
        }

        public void Sorry()
        {
            Console.WriteLine("This is child saying I am sorry.");
        }

    }
}
