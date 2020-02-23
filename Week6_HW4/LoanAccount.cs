using System;
/*
2)  Create a bank application that helps the banker creates bank loan account .  Your application must follow the following requirements:
a) Create an abstract Class LoanAccount that have the following components;
       i) An abstract  decimal CalLoanFees () that takes in the amount of loan the customer requested as a parameter and return the total amount of loan fees that will be charged to the client
      ii) An abstract void DisplayAccountSummary () that outputs all of the account details (Account Routing Number, Account Number, Loan Amount Requested, Total Loan Fee and Total Customer Net Loan). 
     iii) Properties consisting of; RoutingNumber, AccountNumber, RequestedLoanAmount, TotalLoanFees and NetLoanAmount
b) Create 2x Classes PersonalLoanAccount and BusinessLoanAccount that inherits from the abstract class LoanAccount.
c) All Personal Loan Account's routing number should be set automatically to 100 . There is no loan processing fees for this type of account.
d) All Business Loan Account's routing number should be set automatically to 200.  Business loan amount at $10,000 or more will be imposed a 12.322% loan processing fee. Business loan amount that is less than $10,000 will be imposed a 8.573% loan processing fee. 
e) All currency numbers must be formatted correctly.   < 5 pts >
*/

namespace Week6_HW4
{
    public abstract class LoanAccount
    {
        public int AccountNumber { get; set; }
        public decimal LoanAmountRequested { get; set; }
        public decimal TotalLoanFee { get; set; }
        public decimal NetLoanAmount { get; set; }
        public int RoutingNumber { get; set; }

        public abstract decimal CalLoanFees(decimal loanAmount);
        public abstract void DisplayAccountSummary();
    }
}