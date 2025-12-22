using System;

class MultiplicationTable
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] table = new int[10];
        for (int i = 0; i < 10; i++)
        {
            table[i] = (i + 1) * n;
            Console.WriteLine($"{i + 1} * {n} = {table[i]}");
        }
    }
}