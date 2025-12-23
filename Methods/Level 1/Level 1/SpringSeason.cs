using System;

class SpringSeason
{
    static bool IsSpringSeason(int month, int day)
    {
        return (month == 3 && day >= 20) ||
               (month == 4 || month == 5) ||
               (month == 6 && day <= 20);
    }

    static void Main()
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(IsSpringSeason(month, day) ? "Its a Spring Season" : "Not a Spring Season");
    }
}
