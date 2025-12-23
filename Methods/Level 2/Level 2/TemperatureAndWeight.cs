using System;

class UnitConverter3
{
    static double FahrenheitToCelsius(double f) => (f - 32) * 5 / 9;
    static double CelsiusToFahrenheit(double c) => (c * 9 / 5) + 32;
    static double PoundsToKg(double p) => p * 0.453592;
    static double KgToPounds(double kg) => kg * 2.20462;
    static double GallonsToLiters(double g) => g * 3.78541;
    static double LitersToGallons(double l) => l * 0.264172;

    static void Main() 
    {
        Console.WriteLine("1. Fahrenheit to Celsius");
        Console.WriteLine("2. Celsius to Fahrenheit");
        Console.WriteLine("3. Pounds to Kilograms");
        Console.WriteLine("4. Kilograms to Pounds");
        Console.WriteLine("5. Gallons to Liters");
        Console.WriteLine("6. Liters to Gallons");
        Console.Write("Select an option (1-6): ");

        int choice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the value to convert: ");
        double value = Convert.ToDouble(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Result: {FahrenheitToCelsius(value):F2} °C");
                break;
            case 2:
                Console.WriteLine($"Result: {CelsiusToFahrenheit(value):F2} °F");
                break;
            case 3:
                Console.WriteLine($"Result: {PoundsToKg(value):F2} kg");
                break;
            case 4:
                Console.WriteLine($"Result: {KgToPounds(value):F2} lbs");
                break;
            case 5:
                Console.WriteLine($"Result: {GallonsToLiters(value):F2} L");
                break;
            case 6:
                Console.WriteLine($"Result: {LitersToGallons(value):F2} gal");
                break;
            default:
                Console.WriteLine("Invalid selection. Please run the program again.");
                break;
        }
    }
}