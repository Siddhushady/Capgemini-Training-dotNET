using System;

class Factors
{
    static int[] Factor(int n)
    {
        int count = 0;

        for (int i = 1; i <= n; i++)
            if (n % i == 0) count++;

        int[] factors = new int[count];
        int index = 0;

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
                factors[index++] = i;
        }
        return factors;
    }

    static int Sum(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
            sum += factors[i];
        return sum;
    }

    static int Product(int[] factors)
    {
        int product = 1;
        for (int i = 0; i < factors.Length; i++)
            product *= factors[i];
        return product;
    }

    static double SumOfSquares(int[] factors)
    {
        double squareSum = 0;
        for (int i = 0; i < factors.Length; i++)
            squareSum += Math.Pow(factors[i], 2);
        return squareSum;
    }

        static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] factors = Factor(n);
        Console.Write("Factors: ");
        foreach (int f in factors)
            Console.Write(f + " ");

        Console.WriteLine("\nSum of factors: " + Sum(factors));
        Console.WriteLine("Product of factors: " + Product(factors));
        Console.WriteLine("Sum of squares of factors: " + SumOfSquares(factors)); 
    }
}