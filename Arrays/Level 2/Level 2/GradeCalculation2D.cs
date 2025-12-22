using System;

class GradeCalculation2D
{
    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[,] marks = new int[n, 3];   
        double[] percentage = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Enter marks for Student {i + 1}");

            Console.Write("Physics: ");
            marks[i, 0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Chemistry: ");
            marks[i, 1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Maths: ");
            marks[i, 2] = Convert.ToInt32(Console.ReadLine());

            if (marks[i, 0] < 0 || marks[i, 1] < 0 || marks[i, 2] < 0)
            {
                Console.WriteLine("Invalid marks. Enter again.");
                i--;
                continue;
            }

            percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3.0;

            if (percentage[i] >= 80)
                grade[i] = "A";
            else if (percentage[i] >= 70)
                grade[i] = "B";
            else if (percentage[i] >= 60)
                grade[i] = "C";
            else if (percentage[i] >= 50)
                grade[i] = "D";
            else
                grade[i] = "F";
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Student {i + 1} -> Physics: {marks[i, 0]}, Chemistry: {marks[i, 1]}, Maths: {marks[i, 2]}, Percentage: {percentage[i]}, Grade: {grade[i]}");
        }
    }

}

