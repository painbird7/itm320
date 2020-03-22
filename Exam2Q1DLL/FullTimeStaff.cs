using System;

namespace Exam2Q1DLL
{
    public class FullTimeStaff : Staff
    {
        public FullTimeStaff(int employeeID)
        {
            EmployeeCode = 200;
            EmployeeID = employeeID;
        }

        public override decimal CalWage(decimal totalHourWorked)
        {
            decimal payRate = 100.75m;
            decimal pay = Math.Round(payRate * totalHourWorked, 2);
            return pay;
        }
    }
}