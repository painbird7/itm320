using System;

namespace week1_hw2
{
    class WATaxCalculator
    {
        private string welcome = "Welcome to WA Tax Calculator";

        public WATaxCalculator()
        {
            // constructor
            Console.WriteLine(welcome);
        }

        public decimal CalWASalesTax()
        {
            decimal totalAmount;
            // Loop for capturing a valid input
            do
            {
                Console.WriteLine("What is the total amount of purchase? Please enter numbers.");
            } while (!decimal.TryParse(Console.ReadLine(), out totalAmount));

            return totalAmount;
        }

        public decimal WATaxOweCalculator(decimal totalAmount)
        {
            // Calculate tax value based on state tax rate and total amount of purchase
            const decimal waTaxRate = 0.065m;
            decimal taxOwed = totalAmount * waTaxRate;
            return taxOwed;
        }

        public void CalTaxCalculator()
        {
            decimal totalAmount = CalWASalesTax();
            decimal taxOwed = WATaxOweCalculator(totalAmount);

            Console.WriteLine($"The original purchase amount: {totalAmount:C}");
            Console.WriteLine($"Total Sales Tax Amount: {taxOwed:C}");
            Console.WriteLine($"Total Sales and Sales Tax Amount: {(totalAmount + taxOwed):C}");
            Console.ReadLine();
        }
    }
}
