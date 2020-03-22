using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw7_excep
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter a new password.");
                string inputString = Convert.ToString(Console.ReadLine());
                Password myPassword = new Password(inputString);
            }
            catch (LengthCheck e)
            {
                Console.WriteLine(e);
                Console.ReadLine();
            }
        }
    }
}
