using System;

class Quadratic
{
    static double[] FindRoots(double a, double b, double c)
    {
        double delta = b * b - 4 * a * c;
        if (delta < 0) return new double[0];

        if (delta == 0)
            return new double[] { -b / (2 * a) };

        double sqrt = Math.Sqrt(delta);
        return new double[]
        {
            (-b + sqrt) / (2 * a),
            (-b - sqrt) / (2 * a)
        };
    }

    static void Main()
    {
        Console.Write("Enter a, b, c: ");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double[] roots = FindRoots(a, b, c);
        foreach (double r in roots) Console.WriteLine($"Root: {r}");
    }
}
