using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1_hw1
{
    class Calculate
    {
        public void Income(int age)
        {
            // variables for calculation
            const int workWeek = 52;
            const int retireAge = 67;
            int yearToWork = retireAge - age;
            int totalWorkWeek = workWeek * yearToWork;

            // Initialize a dictionary for enumerating each attainment
            Dictionary<string, int> incomeDict = new Dictionary<string, int>()
            {
                {"less than a high school diploma", 520},
                {"graduated with a high school diploma, no college", 721},
                {"some college with no degree", 774},
                {"associate degree", 836},
                {"bachelor's degree", 1173},
                {"master's degree", 1401},
                {"professional degree", 1836}
            };

            // Enumerate each item in the dictionary
            foreach (var item in incomeDict)
            {
                Console.WriteLine($"With the education attainment of {item.Key}, the estimated income over {yearToWork} years is {(item.Value * totalWorkWeek):C}.");
            }

            Console.ReadLine();
        }
    }
}
