using System;

class GradeCalculation
{
    public static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] phy = new int[n];
        int[] chem = new int[n];
        int[] maths = new int[n];
        double[] percent = new double[n];
        string[] grade = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Physics (Student {i+1}): ");
            phy[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Chemistry (Student {i+1}): ");
            chem[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Maths (Student {i+1}): ");
            maths[i] = Convert.ToInt32(Console.ReadLine());

            percent[i] = (phy[i] + chem[i] + maths[i]) / 3.0;

            grade[i] = percent[i] >= 80 ? "A" :
                       percent[i] >= 70 ? "B" :
                       percent[i] >= 60 ? "C" :
                       percent[i] >= 50 ? "D" : "F";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Percentage: {percent[i]}, Grade: {grade[i]}");
    }

}
