using System;

class MultiplicationSixToNine
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        int[] result = new int[4];

        for (int i = 6; i <= 9; i++)
        {
            result[i - 6] = number * i;
            Console.WriteLine($"{number} * {i} = {result[i - 6]}");
        }
    }
}
