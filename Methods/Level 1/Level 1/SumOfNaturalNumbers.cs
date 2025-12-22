using System;

class NaturalSum
{
    static int SumOfNaturalNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Sum of natural numbers: {SumOfNaturalNumbers(n)}");
    }
}
