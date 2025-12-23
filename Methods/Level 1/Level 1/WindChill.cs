using System;

class WindChill
{
    static double CalculateWindChill(double temp, double windSpeed)
    {
        return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(windSpeed, 0.16);
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter wind speed: ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Wind Chill Temperature: {CalculateWindChill(temp, windSpeed)}");
    }
}
