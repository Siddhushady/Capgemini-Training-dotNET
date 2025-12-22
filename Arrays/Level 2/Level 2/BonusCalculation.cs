using System;


class BonusCalculation
{
    public static void Main()
    {
        double[] salary = new double[10];
        double[] service = new double[10];
        double[] bonus = new double[10];
        double[] newSalary = new double[10];

        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Enter salary for employee {i + 1}: ");
            salary[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Enter years of service for employee {i + 1}: ");
            service[i] = Convert.ToDouble(Console.ReadLine());

            if (salary[i] <= 0 || service[i] < 0)
            {
                Console.WriteLine("Invalid input. Enter again.");
                i--;
                continue;
            }
        }

        for (int i = 0; i < 10; i++)
        {
            bonus[i] = service[i] > 5 ? salary[i] * 0.05 : salary[i] * 0.02;
            newSalary[i] = salary[i] + bonus[i];

            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }

        Console.WriteLine($"Total Bonus: {totalBonus}");
        Console.WriteLine($"Total Old Salary: {totalOldSalary}");
        Console.WriteLine($"Total New Salary: {totalNewSalary}");
    }
}