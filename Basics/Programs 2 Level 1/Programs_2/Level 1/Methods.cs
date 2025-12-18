using System;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Methods
{
    public class Method
    {
        public static void AgeOfHarry()
        {
            Console.WriteLine("Harry's Age \n");

            int birthYear = 2000;
            int currentYear = 2024;
            Console.WriteLine("Harry's age in 2024 is " + (currentYear - birthYear) + "\n");
        }

        public static void PCMAverage() 
        {
            Console.WriteLine("PCM Calculation \n");

            Console.WriteLine("Enter Maths marks: ");
            int math = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Physics marks: ");
            int phy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Chemistry marks: ");
            int chem = Convert.ToInt32(Console.ReadLine());

            decimal pcm = (math + phy + chem) / 3;
            Console.WriteLine("Sam’s average mark in PCM is " + pcm + "\n");
        }

        public static void KmToMilesConversion()
        {
            Console.WriteLine("Kilometers to Miles Conversion \n");

            Console.WriteLine("Enter Distance in Kilometers: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = km / 1.6;
            Console.WriteLine("The distance " + km + "km in miles is " + miles + "\n");
        }

        public static void ProfitAndLoss()
        {
            Console.WriteLine("Profit and Loss Calculation \n");

            Console.WriteLine("Enter Cost Price: ");
            double costP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Selling Price: ");
            double sellP = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The Cost is INR " + costP + " and the Selling Price is INR " + sellP);
            double margin;
            double margin_percent;

            if (costP > sellP)
            {
                margin = costP - sellP;
                margin_percent = margin / costP;
                Console.WriteLine("The Loss is INR " + margin + " and the Loss Percentage is " + margin_percent + "\n");
            }
            else
            {
                margin = sellP - costP;
                margin_percent = margin / costP;
                Console.WriteLine("The Profit is INR " + margin + " and the Profit Percentage is " + margin_percent + "\n");
            }
        }

        public static void PenDistribution()
        {
            Console.WriteLine("Equal Distribution of Pens \n");

            Console.WriteLine("Enter number of pens: ");
            int pens = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number of students: ");
            int studs = Convert.ToInt32(Console.ReadLine());

            int quotient = pens / studs;
            int remainder = pens % studs;
            Console.WriteLine("Equal number of pens per student is " +  quotient + " and the number of remaining pens that are not distributed is " +  remainder + "\n");
        }

        public static void FeeDiscount()
        {
            Console.WriteLine("University Fee discount calculation \n");

            Console.WriteLine("Enter original fee: ");
            int originalFee = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter discount percentage: ");
            int discountPercent = Convert.ToInt32(Console.ReadLine());

            double discountAmount = (double) discountPercent / 100 * originalFee;
            double discountFee = originalFee - discountAmount;
            Console.WriteLine("The new discounted University Fee is " + discountFee + "\n");
        }

        public static void VolumeOfEarth()
        {
            Console.WriteLine("Volume of Earth \n");

            double r = 6378;
            Console.WriteLine("Radius of the Earth is " + r + " kms");

            double volumeKM = (4 / 3) * Math.PI * Math.Pow(r,3);
            double volumeMile = volumeKM / 1.6;
            Console.WriteLine("Volume of the Earth in cubic kilometers is " + volumeKM + " and cubic miles is " + volumeMile + "\n");
        }

        public static void HeightConversion()
        {
            Console.WriteLine("Height Conversion \n");

            Console.WriteLine("Enter Height in cms: ");
            double cm = Convert.ToDouble(Console.ReadLine());

            double inch = cm / 2.54;
            double feet = inch / 12;
            Console.WriteLine("Your Height in feet is " + feet + " and inches is " + inch + "\n");
        }

        public static void Calculator()
        {
            Console.WriteLine("Basic Calculator \n");

            Console.WriteLine("Enter N1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition (N1 + N2): " + (n1 + n2));
            Console.WriteLine("Subtraction (N1 - N2): " + (n1 - n2));
            Console.WriteLine("Multiplication (N1 * N2): " + (n1 * n2));
            Console.WriteLine("Divisiom (N1 / N2): " + ((double)n1 / n2));
        }

        public static void AreaOfTriangle()
        {
            Console.WriteLine("Area of a Triangle \n");

            Console.WriteLine("Enter Height in cms: ");
            double h = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Base in cms: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double areaCM = (double) 1 / 2 * b * h;
            double areaInch = (double) areaCM / 2.54;
            Console.WriteLine("Area of the traingle in square cms is " + areaCM + " and in square inches is " + areaInch + "\n");
        }

        public static void SideOfSquare()
        {
            Console.WriteLine("Side of the square \n");

            Console.WriteLine("Enter perimeter: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            double side = (double) perimeter / 4;
            Console.WriteLine("Lenght of the side of the square is " + side + " units \n");
        }

        public static void YardsAndMiles()
        {
            Console.WriteLine("Distance units conversion \n");

            Console.WriteLine("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double yard = (double) feet * 3;
            double mile = (double) yard / 1760;
            Console.WriteLine(feet + " feet is " + yard + " yards and " + mile + " miles \n");
        }

        public static void TotalPrice()
        {
            Console.WriteLine("Total Price calculation \n");

            Console.WriteLine("Enter unit price: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double TotalPrice = (double) unitPrice * quantity;
            Console.WriteLine("Total price is " +  TotalPrice + "\n");
        }

        public static void MaxHandshakes()
        {
            Console.WriteLine("Mamimum number of handshakes \n");

            Console.WriteLine("Enter total number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int max = (n * (n - 1)) / 2;
            Console.WriteLine("The maximum number of handshakes possible is " + max + "\n");
        }
    }
}
