using System;

class EmployeeBonus
{
    static int[,] GenerateData()
    {
        Random rnd = new Random();
        int[,] data = new int[10, 2];

        for (int i = 0; i < 10; i++)
        {
            data[i, 0] = rnd.Next(10000, 99999);
            data[i, 1] = rnd.Next(1, 11);
        }
        return data;
    }

    static void Main()
    {
        int[,] data = GenerateData();
        double totalBonus = 0;

        for (int i = 0; i < 10; i++)
        {
            double bonus = data[i, 1] > 5 ? 0.05 : 0.02;
            double bonusAmt = data[i, 0] * bonus;
            totalBonus += bonusAmt;
        }

        Console.WriteLine("Total Bonus: " + totalBonus);
    }
}
