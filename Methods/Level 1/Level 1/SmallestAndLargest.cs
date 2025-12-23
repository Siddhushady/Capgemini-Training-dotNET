using System;

class SmallestLargest
{
    static int[] FindSmallestAndLargest(int a, int b, int c)
    {
        int smallest = Math.Min(a, Math.Min(b, c));
        int largest = Math.Max(a, Math.Max(b, c));
        return new int[] { smallest, largest };
    }

    static void Main()
    {
        Console.Write("Enter number 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number 3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(a, b, c);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }
}
