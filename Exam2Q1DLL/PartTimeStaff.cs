using System;

namespace Exam2Q1DLL
{
    public class PartTimeStaff : Staff
    {
        public PartTimeStaff(int employeeID)
        {
            EmployeeCode = 100;
            EmployeeID = employeeID;
        }

        public override decimal CalWage(decimal totalHourWorked)
        {
            decimal payRate = 75.75m;
            decimal pay = Math.Round(payRate * totalHourWorked, 2);
            return pay;
        }
    }
}