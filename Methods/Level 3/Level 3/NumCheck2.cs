using System;

class NumberChecker2
{
    static int[] StoreDigits(int number)
    {
        string s = number.ToString();
        int[] digits = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            digits[i] = s[i] - '0';
        return digits;
    }

    static int SumDigits(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits) sum += d;
        return sum;
    }

    static int SumSquares(int[] digits)
    {
        int sum = 0;
        foreach (int d in digits)
            sum += (int)Math.Pow(d, 2);
        return sum;
    }

    static bool IsHarshad(int number, int[] digits)
    {
        return number % SumDigits(digits) == 0;
    }

    static int[,] DigitFrequency(int[] digits)
    {
        int[,] freq = new int[10, 2];
        for (int i = 0; i < 10; i++) freq[i, 0] = i;

        foreach (int d in digits)
            freq[d, 1]++;

        return freq;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        Console.WriteLine("Sum of Digits: " + SumDigits(digits));
        Console.WriteLine("Sum of Squares: " + SumSquares(digits));
        Console.WriteLine("Harshad Number: " + IsHarshad(number, digits));

        int[,] freq = DigitFrequency(digits);
        Console.WriteLine("Digit Frequency:");
        for (int i = 0; i < 10; i++)
            Console.WriteLine($"{freq[i, 0]} -> {freq[i, 1]}");
    }
}
