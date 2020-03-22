using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Exam2Q1DLL;


namespace Exam2Q1Main
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal hourWorked;
            decimal wage;
            string question = "What is hours worked for ";

            Staff jane = new FullTimeStaff(123);
            Console.WriteLine(question + "Jane:");
            hourWorked = Convert.ToDecimal(Console.ReadLine());
            wage = jane.CalWage(hourWorked);
            Console.WriteLine($"Employee Code: {jane.EmployeeCode} \nEmployee ID: {jane.EmployeeID} \nTotal amount of hours worked: {hourWorked} \nTotal pay check wage: {(wage.ToString("C"))} \n");



            Staff jake = new PartTimeStaff(456);
            Console.WriteLine(question + "Jake:");
            hourWorked = Convert.ToDecimal(Console.ReadLine());
            wage = jake.CalWage(hourWorked);
            Console.WriteLine($"Employee Code: {jake.EmployeeCode} \nEmployee ID: {jake.EmployeeID} \nTotal amount of hours worked: {hourWorked} \nTotal pay check wage: {(wage.ToString("C"))} \n");

            Console.ReadLine();
        }
    }
}