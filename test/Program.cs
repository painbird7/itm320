using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Child myChild = new Child();
            //myChild.Smash();
            //myChild.Sorry();

            decimal money = 123.456m;
            double money2 = 123.456;
            Console.WriteLine(money2.ToString("C"));
            Console.WriteLine(money2.ToString("C1"));
            Console.WriteLine(money2.ToString("C2"));
            Console.WriteLine(money2.ToString("C3"));
            Console.WriteLine($"this text yeah i know this is new line and this is the third new line {(money2.ToString("C"))}");

            Console.ReadKey();
            
        }
    }
}
