using System;

class PosNeg
{
    static void Main()
    {
        Console.WriteLine("Enter number of elements in the array: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter value of element {i + 1}");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n");

        for (int i = 0;i < n; i++)
        {
            if (arr[i] == 0)
                Console.WriteLine("Zero, Even");
            else if (arr[i] < 0 && arr[i] % 2 == 0)
                Console.WriteLine("Negative, Even");
            else if (arr[i] < 0 && arr[i] % 2 != 0)
                Console.WriteLine("Negative, Odd");
            else if (arr[i] > 0 && arr[i] % 2 == 0)
                Console.WriteLine("Postive, Even");
            else
                Console.WriteLine("Positive, Odd");
        }
        
    }
}