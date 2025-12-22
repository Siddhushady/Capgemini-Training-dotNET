using System;

class VoterEligibility
{
    static void Main()
    {
        Console.WriteLine("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] age = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter age student {i + 1}: ");
            age[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\n");

        for (int i = 0; i < n; i++)
        {
            if (age[i] <= 0)
                Console.WriteLine($"Student {i + 1}: Invalid age");
            else if (age[i] < 18)
                Console.WriteLine($"Student {i + 1}: Not eligible to vote");
            else
                Console.WriteLine($"Student {i + 1}: Eligible to vote");
        }
    } 
}