using System;
using System.Security.Principal;

namespace Methods
{
    public class Practice
    {
        public void Welcome()
        {
            Console.WriteLine("Welcome to Bridgelabz! \n");
        }

        public void Add()
        {
            Console.WriteLine("Addition of two numbers \n");

            int num1, num2;
            Console.Write("Enter first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse(Console.ReadLine());

            int sum = num1 + num2;
            Console.WriteLine("The sum of two numbers: " + sum + "\n");
        }

        public void CelciusToFahrenheit()
        {
            Console.WriteLine("Temperature Conversion \n");

            double celsius;
            Console.Write("Enter temperature in celcius: ");
            celsius = double.Parse(Console.ReadLine());

            double fahrenheit = (celsius * 9 / 5) + 32;
            Console.WriteLine("Converted into Fahrenheit = " + fahrenheit + "\n");
        }

        public void AreaOfCircle()
        {
            Console.WriteLine("Area of a circle \n");

            double radius;
            Console.Write("Enter radius:");
            radius = double.Parse(Console.ReadLine());

            double area = Math.PI * radius * radius;
            Console.WriteLine("Area of circle : " + area + "\n");
        }

        public void VolumeOfCylinder()
        {
            Console.WriteLine("Volume of a cylinder");

            double radius, height;
            Console.Write("Enter radius: ");
            radius = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            height = double.Parse(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;
            Console.WriteLine("Volume of cylinder = " + volume + "\n");
        }

        public void SimpleInterest()
        {
            Console.WriteLine("Simple Interest calculation \n");

            double principle, rate, time;
            Console.Write("Enter Principle = ");
            principle = double.Parse(Console.ReadLine());
            Console.Write("Enter Rate = ");
            rate = double.Parse(Console.ReadLine());
            Console.Write("Enter Time  = ");
            time = double.Parse(Console.ReadLine());

            double si = (principle * rate * time) / 100;
            Console.WriteLine("Simple Interest = " + si + "\n");

        }

        public void PerimeterOfRectangle()
        {
            Console.WriteLine("Perimeter of a Rectangle \n");

            Console.Write("Enter length: ");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter width: ");
            double width = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (length + width);
            Console.WriteLine("Perimeter = " + perimeter + "\n");
        }

        public void Powercalculation()
        {
            Console.WriteLine("Power Calculation \n");

            Console.Write("Enter base: ");
            double baseNum = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter exponent: ");
            double exponent = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(baseNum, exponent);
            Console.WriteLine("Result = " + result + "\n");
        }

        public void AverageOfThreeNumbers()
        {
            Console.WriteLine("Average of three numbers \n");

            Console.Write("Enter number 1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number 3: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double average = (num1 + num2 + num3) / 3;
            Console.WriteLine("Average = " + average + "\n");
        }

        public void KilometersToMiles()
        {
            Console.WriteLine("Kilometer to Miles Conversion \n");

            Console.Write("Enter distance in kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = km * 0.621371;
            Console.WriteLine("Miles = " + miles + "\n");

        }
    }
}