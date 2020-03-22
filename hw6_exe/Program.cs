using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw6_2;

namespace hw6_exe
{
    class Program
    {
        static void Main(string[] args)
        {
            Bowl myBowl = new Bowl("DEF456", "2019HolidayRed");
            Plate myPlate = new Plate("ABC123", "2019HolidayRed");
            DinnerWareSet myDinnerWareSet = new DinnerWareSet("2019DWSet", 79.99m, "Limited Edition Holiday 2019 Promo", myBowl, myPlate);
            Console.WriteLine(myDinnerWareSet);
            

        }
    }
}
