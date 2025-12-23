using System;

class ArmstrongNumber
{
    static bool IsArmstrong(int number)
    {
        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0)
        {
            int digit = originalNumber % 10;
            sum += digit * digit * digit;
            originalNumber /= 10;
        }

        return sum == number;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsArmstrong(number))
            Console.WriteLine($"{number} is an Armstrong Number");
        else
            Console.WriteLine($"{number} is not an Armstrong Number");
    }
}
