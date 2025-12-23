using System;

class Calendar
{
    static double Calculate(double first, double second, string op)
    {
        switch (op)
        {
            case "+":
                return first + second;
            case "-":
                return first - second;
            case "*":
                return first * second;
            case "/":
                return second != 0 ? first / second : 0;
            default:
                Console.WriteLine("Invalid Operator");
                return 0;
        }
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter operator (+, -, *, /): ");
        string op = Console.ReadLine();

        Console.WriteLine("Result: " + Calculate(first, second, op));
    }
}
