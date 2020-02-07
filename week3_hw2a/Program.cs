using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Author: Jay Han
    Date: 2/2/2020
    ITM320 HW2a

    1) Design an app that measures the user's BMI (Body Mass Index) and diagnose the user' s current health condition based on their BMI Result. The entire app contains 3 classes; HeightConverter , BMICalculator and BMIRangeDiagnostic. 
    The formula for BMI = weight in pounds x 703  divided by height in Inches squared 
    a) Class HeightConverter takes 2x parameters that user enters on Main(). The user's height in Foot , user's height in inches. Example, someone that is 6 ft 2.5" will enter 6 and 2.5 into the app on Main(). 
    The height in Foot would need to be converted into inches by the HeightConverter class.
    b) Class HeightConverter contains a method called HeightConversion()
    HeightConversion() takes the 2 parameters from the user's input in Main() ; height in foot and height in inches. This method must perform the conversion for height in feet into inches (12 inches in 1 foot) and returning the entire user's 
    Height Value in Inches to Main() Eg, 6 foot 2.5 inches should result in (6x12) + 2.5 =  74.5 inches.
    BMICalculator class contains a method call CalculateBMI() that will calculate the user's BMI value (refer to the formula on top of this assignment). this method will require the users total height in Inches and the users weight in pounds (lbs). 
    CalculateBMI() will take in these 2 values as parameters from Main(). After the calculation, the user's BMI result will need to be returned back to Main().
    d) BMIRangeDiagnostic class has a method DetermineBMIDiagnosis() that takes the BMI result from Main() as its parameter. This method will let the user know of their health condition based on their BMI result. The BMI formula is as the following;
    BMI < 18.50 = Clinically Underweight
    BMI 18.5 - 24.99 = Normal Weight
    BMI 25 - 29.99  = Clinically Overweight
    BMI > 30 = Clinically Obese
    Display the user's current health condition into the screen.                         < 5 pts >
 */

namespace week3_hw2a
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get input height
            Console.WriteLine("Please enter the height in ft and inch comma separated form such as 6,2.5 for 6ft 2.5\" and 6,0 for 6ft even.");
            string userInputHeight = Console.ReadLine();
            var inputList = userInputHeight.Split(',').ToList();
            
            // Convert input height to inches
            HeightConverter convertHeight = new HeightConverter();
            double userHeightInch = convertHeight.HeightConversion(Convert.ToInt16(inputList[0]), Convert.ToDouble(inputList[1]));
            Console.WriteLine($"The height is {userHeightInch} inches.");

            // Get input weight
            Console.WriteLine("Please enter the weight in pounds.");
            double userWeightPound = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            BMICalculator myBmiCalculator = new BMICalculator();
            double userBMI = Math.Round(myBmiCalculator.CalculateBMI(userHeightInch, userWeightPound), 2);
            Console.WriteLine($"BMI is {userBMI}.");

            // Compare BMI result and display diagnostics
            BMIRangeDiagnostic myBmiRangeDiagnostic = new BMIRangeDiagnostic();
            Console.WriteLine($"The BMI result of input physique is considered as {myBmiRangeDiagnostic.DetermineBMIDiagnosis(userBMI)}");

            Console.ReadLine();
        }
    }
}
