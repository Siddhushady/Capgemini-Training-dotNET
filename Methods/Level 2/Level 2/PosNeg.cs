using System;

class NumberAnalysis
{
    static bool IsPositive(int n) => n > 0;
    static bool IsEven(int n) => n % 2 == 0;

    static int Compare(int a, int b)
    {
        if (a > b) return 1;
        if (a < b) return -1;
        return 0;
    }

    static void Main()
    {
        int[] arr = new int[5];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            arr[i] = Convert.ToInt32(Console.ReadLine());

            if (IsPositive(arr[i]))
                Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
            else
                Console.WriteLine("Negative or Zero");
        }

        int result = Compare(arr[0], arr[4]);
        Console.WriteLine(result == 0 ? "Equal" : result > 0 ? "First Greater" : "Last Greater");
    }
}
