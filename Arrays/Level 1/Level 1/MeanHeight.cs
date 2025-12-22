using System;

class MeanHeight
{
    static void Main()
    {
        double[] arr = new double[11];
        double total = 0;

        for (int i = 1; i <= 11; i++)
        {
            Console.Write($"Enter Player {i} height: ");
            arr[i] = double.Parse(Console.ReadLine());
            Console.WriteLine();

            total += arr[i];
        }

        double mean = (double) total / 11;
        Console.WriteLine("Mean height: " + mean);
    }
}
