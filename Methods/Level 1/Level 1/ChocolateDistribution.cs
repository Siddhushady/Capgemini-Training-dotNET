using System;

class Chocolates
{
    static int[] FindRemainderAndQuotient(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }

    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of children: ");
        int children = Convert.ToInt32(Console.ReadLine());

        int[] result = FindRemainderAndQuotient(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]} chocolates and remaining {result[1]}");
    }
}
