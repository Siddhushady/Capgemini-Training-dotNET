using System;

public static class Methods
{
    public static void LeapYearIfElse()
    {
        Console.WriteLine("Leap Year using multiple if else statements \n");

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582)
            Console.WriteLine("Not a Leap Year \n");
        else if (year % 400 == 0)
            Console.WriteLine("Leap Year \n");
        else if (year % 100 == 0)
            Console.WriteLine("Not a Leap Year \n");
        else if (year % 4 == 0)
            Console.WriteLine("Leap Year \n");
        else
            Console.WriteLine("Not a Leap Year \n");
    }

    public static void LeapYearSingleIf()
    {
        Console.WriteLine("Leap Year using a single if \n");

        Console.Write("Enter year: ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
            Console.WriteLine("Leap Year \n");
        else
            Console.WriteLine("Not a Leap Year \n");
    }

    public static void GradeCalculation()
    {
        Console.WriteLine("Grade Calculation \n");

        Console.Write("Enter Physics marks: ");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Chemistry marks: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Maths marks: ");
        int maths = Convert.ToInt32(Console.ReadLine());

        double average = (physics + chemistry + maths) / 3.0;
        Console.WriteLine($"Average Marks: {average}");

        switch (average)
        {
            case >= 80:
                Console.WriteLine("Grade: A | Remarks: Level 4 \n");
                break;
            case >= 70:
                Console.WriteLine("Grade: B | Remarks: Level 3 \n");
                break;
            case >= 60:
                Console.WriteLine("Grade: C | Remarks: Level 2 \n");
                break;
            case >= 50:
                Console.WriteLine("Grade: D | Remarks: Level 1 \n");
                break;
            case >= 40:
                Console.WriteLine("Grade: E | Remarks: Level 1- \n");
                break;
            default:
                Console.WriteLine("Grade: R | Remarks: Remedial \n");
                break;
        }
    }

    public static void PrimeCheck()
    {
        Console.WriteLine("Check if a number is Prime \n");

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = number > 1;

        for (int i = 2; i <= number / 2 && isPrime; i++)
        {
            if (number % i == 0)
                isPrime = false;
        }

        Console.WriteLine(isPrime ? "Prime Number \n" : "Not a Prime Number \n");
    }

    public static void FizzBuzzFor()
    {
        Console.WriteLine("FizzBuzz using for loop \n");

        Console.Write("Enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);
        }
        Console.WriteLine("\n");
    }

    public static void FizzBuzzWhile()
    {
        Console.WriteLine("FizzBuzz using while loop \n");

        Console.Write("Enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int i = 1;

        while (i <= n)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Console.WriteLine("FizzBuzz");
            else if (i % 3 == 0)
                Console.WriteLine("Fizz");
            else if (i % 5 == 0)
                Console.WriteLine("Buzz");
            else
                Console.WriteLine(i);

            i++;
        }
        Console.WriteLine("\n");
    }

    public static void BMICalculation()
    {
        Console.WriteLine("BMI Calculation \n");

        Console.Write("Enter weight (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height (cm): ");
        double heightCm = Convert.ToDouble(Console.ReadLine());

        double heightM = heightCm / 100;
        double bmi = weight / (heightM * heightM);
        Console.WriteLine($"BMI: {bmi}");

        switch (bmi)
        {
            case <= 18.4:
                Console.WriteLine("Underweight \n");
                break;
            case <= 24.9:
                Console.WriteLine("Normal \n");
                break;
            case <= 39.9:
                Console.WriteLine("Overweight \n");
                break;
            default:
                Console.WriteLine("Obese \n");
                break;
        }
    }

    public static void YoungestAndTallest()
    {
        Console.WriteLine("Youngest and Tallest of 3 people \n");

        Console.Write("Enter Amar age & height: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        double amarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Akbar age & height: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        double akbarHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Anthony age & height: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());

        int youngestAge = Math.Min(amarAge, Math.Min(akbarAge, anthonyAge));
        double tallestHeight = Math.Max(amarHeight, Math.Max(akbarHeight, anthonyHeight));

        Console.WriteLine($"Youngest Age: {youngestAge}");
        Console.WriteLine($"Tallest Height: {tallestHeight} \n");
    }

    public static void GreatestFactor()
    {
        Console.WriteLine("Greatest factor \n");

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--)
        {
            if (number % i == 0)
            {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine($"Greatest factor is {greatestFactor} \n");
    }

    public static void PowerOfNumber()
    {
        Console.WriteLine("Power of a number using for loop \n");

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;
        for (int i = 1; i <= power; i++)
            result *= number;

        Console.WriteLine($"Result: {result} \n");
    }

    public static void Factors()
    {
        Console.WriteLine("Factors of a number \n");

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < number; i++)
            if (number % i == 0)
                Console.WriteLine(i);
        Console.WriteLine("\n");
    }

    public static void MultiplesBelow100()
    {
        Console.WriteLine("Multiples of the given number below 100");

        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 100; i >= 1; i--)
            if (i % number == 0)
                Console.WriteLine(i);
        Console.WriteLine("\n");
    }
}
