using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week1_hw1;

/*
    Author: Jay Han
    Date: 1/26/2020
    ITM320 HW1
    
    Program Requirements:
    a.Design an application that calculates the amount of salary a person can make in their "working lifetime" with the following criteria
    1) Less than a high school diploma=520
    2) Graduated with a high school diploma, no college=712
    3) Some college with no degree=774
    4) Associate degree=836
    5) Bachelor's degree=1173
    6) Master's degree=1401
    7) Professional degree=1836
    Use the following data from the U.S Bureau of Labor Stats for your application (Assume that an annual work week is 52): https://www.bls.gov/careeroutlook/2018/data-on-display/education-pays.htm
    Your application must be able to do the following:
    a) Ask the user for their expected starting working age(min 16 years old).
    b) The retiring working age for a person born in 1960 or later is 67.
    c) List the amount of income that person will be able to make throughout their entire working lifetime based on criteria(1) to(7) above.Note: You do not have to calculate for inflation, investment or any other criteria.   < 5 pts >
*/

namespace Week1_HW1
{
    class Program
    {
        static void Main()
        {
            // Initialize UserInput class and assign the output to age variable
            UserInput getUserInput = new UserInput();
            int age = getUserInput.Input();
            
            // Initialize Calculate class and pass age variable to Income method.
            Calculate accumulateIncome = new Calculate();
            accumulateIncome.Income(age);
        }
    }
}

