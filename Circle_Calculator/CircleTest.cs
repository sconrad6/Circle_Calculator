using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Circle_Calculator
{
    class CircleTest
    {
        static void Main(string[] args)
        {
            //In the Main method, get the user input, create a Circle object, and display
            //the circumference and area.
            Console.WriteLine("Welcome to the circle area and perimeter calculator!");
            int count = 0;
            string userChoice;
            do
            {   
                Console.WriteLine("Please enter a radius");
                string radius = Console.ReadLine();

                if (Validator.InputValidator(radius))
                {
                    Circle circle = new Circle(int.Parse(radius));
                    circle.Radius = int.Parse(radius);
                    Console.WriteLine(circle.CalculateFormattedCircumference());
                    Console.WriteLine(circle.CalculateFormattedArea());
                    count++;
                }

            Start:
                Console.WriteLine("\nWould you like to calculate for another circle? (Y/N)");
                userChoice = Console.ReadLine().ToLower();

                if (!Validator.ChoiceValidator(userChoice))
                {
                    goto Start;
                }


            } while (userChoice == "y");
            Console.WriteLine(Circle.FormatNumber(count));
        }
    }
        
}
