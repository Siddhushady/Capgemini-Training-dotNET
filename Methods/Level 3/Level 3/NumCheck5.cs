using System;

class NumberChecker5
{
    static int[] FindFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
            if (n % i == 0) factors[index++] = i;

        return factors;
    }

    static int SumFactors(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length - 1; i++)
            sum += factors[i];
        return sum;
    }

    static bool IsPerfect(int n)
    {
        return SumFactors(FindFactors(n)) == n;
    }

    static bool IsAbundant(int n)
    {
        return SumFactors(FindFactors(n)) > n;
    }

    static bool IsDeficient(int n)
    {
        return SumFactors(FindFactors(n)) < n;
    }

    static bool IsStrong(int n)
    {
        int temp = n, sum = 0;
        while (temp > 0)
        {
            int d = temp % 10;
            int fact = 1;
            for (int i = 1; i <= d; i++) fact *= i;
            sum += fact;
            temp /= 10;
        }
        return sum == n;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Perfect: " + IsPerfect(n));
        Console.WriteLine("Abundant: " + IsAbundant(n));
        Console.WriteLine("Deficient: " + IsDeficient(n));
        Console.WriteLine("Strong: " + IsStrong(n));
    }
}
