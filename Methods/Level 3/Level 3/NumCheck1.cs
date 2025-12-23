using System;

class NumberChecker1
{
    static int CountDigits(int number)
    {
        int count = 0;
        while (number != 0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    static int[] StoreDigits(int number)
    {
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i = count - 1; i >= 0; i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }
        return digits;
    }

    static bool IsDuck(int[] digits)
    {
        foreach (int d in digits)
            if (d == 0) return true;
        return false;
    }

    static bool IsArmstrong(int[] digits)
    {
        int sum = 0;
        int power = digits.Length;

        foreach (int d in digits)
            sum += (int)Math.Pow(d, power);

        int original = 0;
        foreach (int d in digits)
            original = original * 10 + d;

        return sum == original;
    }

    static void FindLargestSecondLargest(int[] digits)
    {
        int largest = Int32.MinValue;
        int second = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d > largest)
            {
                second = largest;
                largest = d;
            }
            else if (d > second && d != largest)
                second = d;
        }

        Console.WriteLine($"Largest: {largest}, Second Largest: {second}");
    }

    static void FindSmallestSecondSmallest(int[] digits)
    {
        int smallest = Int32.MaxValue;
        int second = Int32.MaxValue;

        foreach (int d in digits)
        {
            if (d < smallest)
            {
                second = smallest;
                smallest = d;
            }
            else if (d < second && d != smallest)
                second = d;
        }

        Console.WriteLine($"Smallest: {smallest}, Second Smallest: {second}");
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        Console.WriteLine("Duck Number: " + IsDuck(digits));
        Console.WriteLine("Armstrong Number: " + IsArmstrong(digits));
        FindLargestSecondLargest(digits);
        FindSmallestSecondSmallest(digits);
    }
}
