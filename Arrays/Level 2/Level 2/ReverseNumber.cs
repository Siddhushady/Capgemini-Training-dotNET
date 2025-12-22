using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int temp = number, count = 0;
        while (temp != 0)
        {
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        Console.Write("Reversed Number: ");
        for (int i = 0; i < count; i++)
            Console.Write(digits[i]);
    }
}
