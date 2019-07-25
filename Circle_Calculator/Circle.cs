using System;
namespace Circle_Calculator
{
    public class Circle
    {
        private double radius;
        

        // properties to get and set the radius
      
        public double Radius // can use this and a default constructor to read in and set the information from the user
        {
            get => radius;
            set => radius = value;
        }

        // constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        // calculates the circle's circumference 
        public double CalculateCircumference()
        {
            return (2 * Math.PI * radius);
        }

        // format the circumference to two decimal places and adds text
        public string CalculateFormattedCircumference()
        {
            return $"The circumference of the circle is {Math.Round(CalculateCircumference(), 2)}";
        }

        // calculates the area
        public double CalculateArea()
        {
            return (Math.Pow(radius, 2) * Math.PI);
        }

        //format the area to two decimal places and adds text
        public string CalculateFormattedArea()
        {
            return $"The area of the circle is {Math.Round(CalculateArea(), 2)}";
        }

        // find the number of circles the user made
        public static string FormatNumber(double x) 
        {
            return $"Goodbye.\nYou created {x} circle(s).";
        }

    }
}
