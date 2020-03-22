using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    2) Design an application that uses the C# random generator to randomly roll a six face dice ( no 1 - no 6) . If the user rolled a no 3 , 
    the user gets to roll the six face die one more time.  You must use a switch statement to write the result /s of the random dice roll/s to the screen.  
    Hint: You should have nested switches in your program to evaluate the second dice roll 
*/

namespace Week7_HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice myDice = new Dice(); // Initialize Dice class
            int diceNumber; 
            Console.WriteLine("Press enter key to roll a die. Yielding 3 will grant an extra roll.");
            Console.ReadLine();
            do // do while loop for reroll if die rolls 3
            {
                diceNumber = myDice.Roll(1, 6);
                switch (diceNumber)
                {
                    case 1:
                        Console.WriteLine("You threw 1");
                        break;
                    case 2:
                        Console.WriteLine("You threw 2");
                        break;
                    case 3:
                        Console.WriteLine("Congrats! You threw 3! Press any key to roll a die again.");
                        break;
                    case 4:
                        Console.WriteLine("You threw 4");
                        break;
                    case 5:
                        Console.WriteLine("You threw 5");
                        break;
                    case 6:
                        Console.WriteLine("You threw 6");
                        break;
                }
            } while (diceNumber == 3);
        }
    }
}
