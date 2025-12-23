using System;

class UnitConverter1
{
    static double ConvertKmToMiles(double km) => km * 0.621371;
    static double ConvertMilesToKm(double miles) => miles * 1.60934;
    static double ConvertMetersToFeet(double meters) => meters * 3.28084;
    static double ConvertFeetToMeters(double feet) => feet * 0.3048;

    static void Main()
    {
        Console.WriteLine("Select Conversion:");
        Console.WriteLine("1. Km to Miles");
        Console.WriteLine("2. Miles to Km");
        Console.WriteLine("3. Meters to Feet");
        Console.WriteLine("4. Feet to Meters");
        Console.Write("Choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter value to convert: ");
        double input = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {ConvertKmToMiles(input)} miles");
                break;
            case 2:
                Console.WriteLine($"Result: {ConvertMilesToKm(input)} km");
                break;
            case 3:
                Console.WriteLine($"Result: {ConvertMetersToFeet(input)} feet");
                break;
            case 4:
                Console.WriteLine($"Result: {ConvertFeetToMeters(input)} meters");
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }
    }
}