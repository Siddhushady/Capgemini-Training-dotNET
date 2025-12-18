using System;

public static class Methods
{
    public static void CheckDivisibleBy5()
    {
        Console.WriteLine("Check if a number is divisible by 5 \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool result = number % 5 == 0;
        Console.WriteLine($"Is the number {number} divisible by 5? {result} \n");
    }

    public static void FirstIsSmallest()
    {
        Console.WriteLine("Check if the first number is smallest number \n");

        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        bool result = a < b && a < c;
        Console.WriteLine($"Is the first number the smallest? {result} \n");
    }

    public static void LargestOfThree()
    {
        Console.WriteLine("Largest of 3 numbers \n");

        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Is the first number the largest? {a > b && a > c}");
        Console.WriteLine($"Is the second number the largest? {b > a && b > c}");
        Console.WriteLine($"Is the third number the largest? {c > a && c > b} \n");
    }

    public static void NaturalNumberSum()
    {
        Console.WriteLine("Sum of N natural numbers \n");

        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sum = n * (n + 1) / 2;
            Console.WriteLine($"The sum of {n} natural numbers is {sum}");
        }
        else
        {
            Console.WriteLine($"The number {n} is not a natural number");
        }
    }

    public static void CanVote()
    {
        Console.WriteLine("Check if a person is eligible to vote \n");

        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age >= 18)
            Console.WriteLine($"The person's age is {age} and can vote \n");
        else
            Console.WriteLine($"The person's age is {age} and cannot vote \n");
    }

    public static void CheckNumberType()
    {
        Console.WriteLine("Check the sign of number");

        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0) Console.WriteLine("Positive \n");
        else if (n < 0) Console.WriteLine("Negative \n");
        else Console.WriteLine("Zero \n");
    }

    public static void SpringSeason()
    {
        Console.WriteLine("Check if the given date is in spring season");

        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring =
            (month == 3 && day >= 20) ||
            (month > 3 && month < 6) ||
            (month == 6 && day <= 20);

        Console.WriteLine(isSpring ? "Its a Spring Season \n" : "Not a Spring Season \n");
    }

    public static void CountdownWhile()
    {
        Console.WriteLine("Countdown using while loop \n");

        Console.Write("Enter countdown number: ");
        int counter = Convert.ToInt32(Console.ReadLine());

        while (counter >= 1)
        {
            Console.WriteLine(counter);
            counter--;
        }
        Console.WriteLine("\n");
    }

    public static void CountdownFor()
    {
        Console.WriteLine("Countdown using for loop \n");

        Console.Write("Enter countdown number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = n; i >= 1; i--)
            Console.WriteLine(i);
        Console.WriteLine("\n");
    }

    public static void SumUntilZero()
    {
        Console.WriteLine("Sum of numbers until 0 is entered \n");

        double total = 0;
        double value;

        do
        {
            Console.Write("Enter a number (0 to stop): ");
            value = Convert.ToDouble(Console.ReadLine());
            total += value;
            Console.WriteLine($"Total sum till now is {total}");
        } while (value != 0);
    }

    public static void SumUntilZeroOrNegative()
    {
        Console.WriteLine("Sum of numbers until 0 or negative number is entered \n");

        double total = 0;
        while (true)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double value = Convert.ToDouble(Console.ReadLine());

            if (value <= 0)
                break;

            total += value;
            Console.WriteLine($"Total sum till now is {total}");
        }
    }

    public static void SumNaturalWhile()
    {
        Console.Write("Sum of N natural numbers comparision (while) \n");

        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sumLoop = 0, i = 1;
            while (i <= n)
            {
                sumLoop += i;
                i++;
            }

            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine($"While loop sum: {sumLoop}");
            Console.WriteLine($"Formula sum: {sumFormula}  \n");
        }
    }

    public static void SumNaturalFor()
    {
        Console.Write("Sum of N natural numbers comparision (for) \n");

        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int sumLoop = 0;
            for (int i = 1; i <= n; i++)
                sumLoop += i;

            int sumFormula = n * (n + 1) / 2;
            Console.WriteLine($"For loop sum: {sumLoop}");
            Console.WriteLine($"Formula sum: {sumFormula} \n");
        }
    }

    public static void FactorialWhile()
    {
        Console.WriteLine("Factorial of a number using while loop \n");

        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int fact = 1, i = 1;
            while (i <= n)
            {
                fact *= i;
                i++;
            }
            Console.WriteLine($"Factorial is {fact} \n");
        }
    }

    public static void FactorialFor()
    {
        Console.WriteLine("Factorila of a number using for loop \n");

        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n > 0)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;

            Console.WriteLine($"Factorial is {fact}  \n");
        }
    }

    public static void OddEven()
    {
        Console.WriteLine("All odd and even numbers from 0 till given number \n");

        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= n; i++)
            Console.WriteLine($"{i} is {(i % 2 == 0 ? "Even \n" : "Odd \n")}");
    }

    public static void EmployeeBonus()
    {
        Console.WriteLine("Employee Bonus \n");

        Console.Write("Enter salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter years of service: ");
        int years = Convert.ToInt32(Console.ReadLine());

        if (years > 5)
            Console.WriteLine($"Bonus amount is {salary * 0.05} \n");
        else
            Console.WriteLine("No bonus \n");
    }

    public static void MultiplicationTable()
    {
        Console.WriteLine("Multiplication table \n");

        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
            Console.WriteLine($"{number} * {i} = {number * i}");
    }
}
