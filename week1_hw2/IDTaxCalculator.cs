using System;

namespace week1_hw2
{
    class IDTaxCalculator
    {
        private string welcome = "Welcome to ID Tax Calculator";
        
        public IDTaxCalculator()
        {
            // constructor
            Console.WriteLine(welcome);
        }

        public decimal CalIDSalesTax()
        {
            decimal totalAmount;
            // Loop for capturing a valid input
            do
            {
                Console.WriteLine("What is the total amount of purchase? Please enter numbers.");
            } while (!decimal.TryParse(Console.ReadLine(), out totalAmount));

            return totalAmount;
        }

        public decimal IDTaxOweCalculator(decimal totalAmount)
        {
            // Calculate tax value based on state tax rate and total amount of purchase
            const decimal idTaxRate = 0.06m;
            decimal taxOwed = totalAmount * idTaxRate;
            return taxOwed;
        }

        public void CalTaxCalculator()
        {
            decimal totalAmount = CalIDSalesTax();
            decimal taxOwed = IDTaxOweCalculator(totalAmount);

            Console.WriteLine($"The original purchase amount: {totalAmount:C}");
            Console.WriteLine($"Total Sales Tax Amount: {taxOwed:C}");
            Console.WriteLine($"Total Sales and Sales Tax Amount: {(totalAmount + taxOwed):C}");
            Console.ReadLine();
        }
    }
}
