using System;

public static class Methods
{
    public static void ArmstrongNumber()
    {
        Console.WriteLine("Amstrong Number \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int remainder = originalNumber % 10;
            sum += remainder * remainder * remainder;
            originalNumber /= 10;
        }

        if (sum == number)
            Console.WriteLine("Armstrong Number \n");
        else
            Console.WriteLine("Not an Armstrong Number \n");
    }

    public static void CountDigits()
    {
        Console.WriteLine("Count number of digits \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;

        while (number != 0)
        {
            number /= 10;
            count++;
        }

        Console.WriteLine($"Number of digits: {count} \n");
    }

    public static void HarshadNumber()
    {
        Console.WriteLine("Harshad Number \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;

        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }

        if (originalNumber % sum == 0)
            Console.WriteLine("Harshad Number \n");
        else
            Console.WriteLine("Not a Harshad Number \n");
    }

    public static void AbundantNumber()
    {
        Console.WriteLine("Abundant Number \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;

        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                sum += i;
        }

        if (sum > number)
            Console.WriteLine("Abundant Number \n");
        else
            Console.WriteLine("Not an Abundant Number \n");
    }

    public static void DayOfWeek()
    {
        Console.WriteLine("Day of the week \n");

        Console.Write("Enter month: ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day: ");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter year: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + (31 * m0) / 12) % 7;

        Console.WriteLine($"Day of week: {d0} \n");
    }

    public static void Calculator()
    {
        Console.WriteLine("Calculator \n");

        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {first + second}");
                break;
            case "-":
                Console.WriteLine($"Result: {first - second}");
                break;
            case "*":
                Console.WriteLine($"Result: {first * second}");
                break;
            case "/":
                Console.WriteLine($"Result: {first / second}");
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}
