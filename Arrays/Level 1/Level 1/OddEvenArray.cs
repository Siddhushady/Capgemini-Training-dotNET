using System;

class OddEvenArray
{
    static void Main()
    {
        Console.Write("Enter a natural number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }


        int[] odd = new int[n / 2 + 1];
        int[] even = new int[n / 2 + 1];

        int e = 0;
        int o = 0;

        for (int i = 0; i <= n; i++)
        {
            if (i % 2 == 0)
                even[e++] = i;
            else
                odd[o++] = i;
        }

        Console.Write("Even Array: ");
        for (int i = 0; i < e; i++)
            Console.Write(even[i] + " ");

        Console.Write("\nOdd Array: ");
        for (int i = 0; i < o; i++)
            Console.Write(odd[i] + " ");
    }
}

