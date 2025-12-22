using System;

class Trigonometry
{
    static double[] CalculateTrigonometricFunctions(double angle)
    {
        double rad = angle * Math.PI / 180;
        return new double[] { Math.Sin(rad), Math.Cos(rad), Math.Tan(rad) };
    }

    static void Main()
    {
        Console.Write("Enter angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        double[] result = CalculateTrigonometricFunctions(angle);
        Console.WriteLine($"Sin: {result[0]}, Cos: {result[1]}, Tan: {result[2]}");
    }
}
