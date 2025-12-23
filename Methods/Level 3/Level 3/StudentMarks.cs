using System;

class StudentMarks
{
    static int[,] GenerateMarks(int n)
    {
        Random rnd = new Random();
        int[,] marks = new int[n, 3];

        for (int i = 0; i < n; i++)
            for (int j = 0; j < 3; j++)
                marks[i, j] = rnd.Next(10, 100);

        return marks;
    }

    static void Main()
    {
        Console.Write("Students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] marks = GenerateMarks(n);

        for (int i = 0; i < n; i++)
        {
            int total = marks[i, 0] + marks[i, 1] + marks[i, 2];
            double avg = Math.Round(total / 3.0, 2);
            double percent = Math.Round(total / 300.0 * 100, 2);

            Console.WriteLine($"{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t{total}\t{avg}\t{percent}");
        }
    }
}
