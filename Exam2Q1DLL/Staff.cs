namespace Exam2Q1DLL
{
    public abstract class Staff
    {
        public abstract decimal CalWage(decimal totalHourWorked);
        public int EmployeeCode { get; set; }
        public int EmployeeID { get; set; }

    }
}