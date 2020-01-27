using System;

/*
    Author: Jay Han
    Date: 1/26/2020
    ITM320 HW2
    
    Requirements:
    b. Create an application in C# console app that calculates the sales tax for their purchase. The application asks the user for their state (ID or WA) and perform the appropriate operations as outlined below. 
    Assume that ID sales tax is 6% and WA sales tax is 6.5%
    Below is the instruction for the ID portion of the question, the WA portion of the question is exactly the same as below (except remember to change everything "ID" to "WA" for the WA part of the problem).
    1) Create a class name "IDTaxCalculator" and a constructor that outputs "Welcome to ID Tax Calculator".
    2) Create a method CalIDSalesTax() that ask the user for the total of their purchase amount. 
    3) Create another method called IDTaxOweCalculator()  that receives the total of the purchase amount from CalIDSalesTax(). 
    4) IDTaxOweCalculator() will calculate the amount of tax owe based on the purchase amount and then RETURNS the value back to CalIDSalesTax().
    5) CalTaxCalculator() will then perform the rest of the relevant calculations and output to the screen "The original purchase amount:", the "Total Sales Tax Amount" and the "Total Sales and Sales Tax Amount" . 
    For ID selection. Instantiate an object "myIDTaxCalculator" out of the IDTaxCalculator class and perform the entire operation based on the requirement above.
    For WA selection. Instantiate an object "myWATaxCalculator" out of the WATaxCalculator class and perform the entire operation based on the requirement above.  <5 pts >

*/

namespace week1_hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What state are you in?");
            string state = Console.ReadLine().ToLower();
            if (state == "id")
            {
                IDTaxCalculator myIDTaxCalculator = new IDTaxCalculator();
                myIDTaxCalculator.CalTaxCalculator();
            }
            else if (state == "wa")
            {
                WATaxCalculator myWaTaxCalculator = new WATaxCalculator();
                myWaTaxCalculator.CalTaxCalculator();
            }
            else
            {
                Console.WriteLine("Please rerun the program. Valid inputs are ID and WA.");
                Console.ReadLine();
            }
        }
    }
}
