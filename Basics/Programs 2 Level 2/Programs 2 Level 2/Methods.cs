using System;
using System.Security;

namespace Methods
{
    public class Method
    {
        public static void Division()
        {
            Console.WriteLine("Qoutient and Remainder of given 2 numbers \n");

            Console.WriteLine("Enter Dividend: ");
            double dividend = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Divisor: ");
            double divisor = Convert.ToDouble(Console.ReadLine());

            double quotient = (double)dividend / divisor;
            double remainder = (double)dividend % divisor;
            Console.WriteLine("Quotient: " + quotient + "\nRemainder: " + remainder + "\n");
        }

        public static void IntOps()
        {
            Console.WriteLine("Integer Operations on three numbers \n");

            Console.WriteLine("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int op1 = a + b * c;
            int op2 = a * b + c;
            int op3 = c + a / b;
            int op4 = a % b + c;
            Console.WriteLine("a + b * c = " + op1);
            Console.WriteLine("a * b + c = " + op2);
            Console.WriteLine("c + a / b = " + op3);
            Console.WriteLine("a % b + c = " + op4 + "\n");
        }

        public static void DoubleOps()
        {
            Console.WriteLine("Double Operations on three numbers \n");

            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double op1 = (double)a + b * c;
            double op2 = (double)a * b + c;
            double op3 = (double)c + a / b;
            double op4 = (double)a % b + c;
            Console.WriteLine("a + b * c = " + op1);
            Console.WriteLine("a * b + c = " + op2);
            Console.WriteLine("c + a / b = " + op3);
            Console.WriteLine("a % b + c = " + op4 + "\n");
        }

        public static void CelsiusToFahrenheit()
        {
            Console.WriteLine("Celsius to Fahrenheit Converison \n");

            Console.WriteLine("Enter temperature in degree Celsius: ");
            double c = Convert.ToDouble(Console.ReadLine());

            double f = (double) c * 9 / 5 + 32;
            Console.WriteLine("Temperature in Fahrenheit is " + f + " degrees \n");
        }

        public static void FahrenheitToCelsius()
        {
            Console.WriteLine("Fahrenheit Converison \n");

            Console.WriteLine("Enter temperature in degree Fahrenheit: ");
            double f = Convert.ToDouble(Console.ReadLine());

            double c = (double)(f - 32) * 5 / 9;
            Console.WriteLine("Temperature in Celsius is " + c + " degrees \n");
        }

        public static void TotalIncome()
        {
            Console.WriteLine("Total Income \n");

            Console.WriteLine("Enter Salary: ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Bonus: ");
            int bonus = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Total income is " + (salary + bonus) + " INR \n");
        }

        public static void SwapNumbers()
        {
            Console.WriteLine("Swap numbers \n");

            Console.WriteLine("Enter N1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swapping: \nN1: " + n1 + "\nN2: " + n2 + "\n");
        }

        public static void Tour()
        {
            Console.WriteLine("Tour details \n");

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter starting city: ");
            string fromCity = Console.ReadLine();
            Console.WriteLine("Enter via city: ");
            string viaCity = Console.ReadLine();
            Console.WriteLine("Enter destination city: ");
            string toCity = Console.ReadLine();

            Console.WriteLine("Enter distance from start city to via city (in miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter distance from via city to destination city (in miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter total time taken for the journey (in hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());

            double totalDistance = fromToVia + viaToFinalCity;
            double speed = totalDistance / timeTaken;

            Console.WriteLine($"Passenger name: {name}");
            Console.WriteLine($"Route: {fromCity} -> {viaCity} -> {toCity}");
            Console.WriteLine($"Total Distance: {totalDistance} miles");
            Console.WriteLine($"Average Speed: {speed} miles/hour \n");
        }

        public static void TriangularPark()
        {
            Console.WriteLine("Number of rounds possible in a triangular park \n");

            Console.WriteLine("Enter Lengths of sides of the triangular park in kms");
            Console.WriteLine("Side 1: ");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side 2: ");
            double side2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Side 3: ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double perimeter = side1 + side2 + side3;
            double rounds = (double) 5 / perimeter;
            Console.WriteLine($"Number of rounds needed to finish 5km is {rounds} \n");
        }

        public static void DistributeChocolates()
        {
            Console.WriteLine("Distribution of Chocolates \n");

            Console.WriteLine("Enter number of Chocolates: ");
            int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of Children: ");
            int numberOfChildren = Convert.ToInt32(Console.ReadLine());

            int eachGets = numberOfChocolates / numberOfChildren;
            int remaining = numberOfChocolates % numberOfChildren;
            Console.WriteLine($"The number of chocolates each child gets is {eachGets} and the number of remaining chocolates is {remaining} \n");
        }

        public static void CalculateSimpleInterest()
        {
            Console.WriteLine("Simple Interest Calculation \n");

            Console.WriteLine("Enter Principal amount: ");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Rate of interest: ");
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Number of Years: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (double)(principal * rate * time) / 100;
            Console.WriteLine($"The Simple Interest is {simpleInterest} \n");
        }

        public static void ConvertPoundsToKg()
        {
            Console.WriteLine("Pounds to Kilogram conversion \n");

            Console.WriteLine("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kg = pounds / 2.2;
            Console.WriteLine($"The weight of the person in pounds is {pounds} and in kg is {kg}");
        }
    }
}
