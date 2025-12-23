using System;

class UnitConverter2
{
    static double ConvertYardsToFeet(double yards) => yards * 3;
    static double ConvertFeetToYards(double feet) => feet * 0.333333;
    static double ConvertMetersToInches(double meters) => meters * 39.3701;
    static double ConvertInchesToMeters(double inches) => inches * 0.0254;
    static double ConvertInchesToCm(double inches) => inches * 2.54;

    static void Main()
    {
        Console.WriteLine("Select Conversion:");
        Console.WriteLine("1. Yards to Feet");
        Console.WriteLine("2. Feet to Yards");
        Console.WriteLine("3. Meters to Inches");
        Console.WriteLine("4. Inches to Meters");
        Console.WriteLine("5. Inches to Cm");
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value to convert: ");
        double input = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {ConvertYardsToFeet(input)} feet");
                break;
            case 2:
                Console.WriteLine($"Result: {ConvertFeetToYards(input)} yards");
                break;
            case 3:
                Console.WriteLine($"Result: {ConvertMetersToInches(input)} inches");
                break;
            case 4:
                Console.WriteLine($"Result: {ConvertInchesToMeters(input)} meters");
                break;
            case 5:
                Console.WriteLine($"Result: {ConvertInchesToCm(input)} cm");
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}