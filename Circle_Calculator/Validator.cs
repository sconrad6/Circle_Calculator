using System;
using System.Text.RegularExpressions;

namespace Circle_Calculator
{
    public class Validator
    {
        //validates that the input from the user is valid
        public static bool InputValidator(string radius)
        {
            try
            {
                double.Parse(radius);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("This radius is invalid.");
                return false;
            }
        }

        public static bool ChoiceValidator(string userChoice)
        {
            try
            {
                int.Parse(userChoice);
                Console.WriteLine("Invalid, try again.");
                return false;
            }
            catch (Exception)
            { 
                return true;
            }
        }
    }
}
