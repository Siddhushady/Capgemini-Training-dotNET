using System;

class AthleteRun
{
    static double CalculateRounds(double a, double b, double c)
    {
        double perimeter = a + b + c;
        return 5000 / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Number of rounds required: {CalculateRounds(a, b, c)}");
    }
}
