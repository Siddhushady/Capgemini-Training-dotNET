using System;

class LineMath
{
    static double Distance(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    static double[] LineEquation(double x1, double y1, double x2, double y2)
    {
        double m = (y2 - y1) / (x2 - x1);
        double b = y1 - m * x1;
        return new double[] { m, b };
    }

    static void Main()
    {
        double[] line = LineEquation(2, 4, 4, 6);
        Console.WriteLine("Distance: " + Distance(2, 4, 4, 6));
        Console.WriteLine($"y = {line[0]}x + {line[1]}");
    }
}
