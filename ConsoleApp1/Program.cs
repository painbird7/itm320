using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Specialized;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = new CSV();
            var data = csv.ReadCSV();
            Console.Read();
        }
    }
}
