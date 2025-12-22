using System;

class BMICalculation
{
    public static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[] weight = new double[n];
        double[] height = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter weight (kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (m): ");
            height[i] = Convert.ToDouble(Console.ReadLine());

            bmi[i] = weight[i] / (height[i] * height[i]);

            status[i] = bmi[i] < 18.5 ? "Underweight" :
                        bmi[i] < 25 ? "Normal" :
                        bmi[i] < 30 ? "Overweight" : "Obese";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Height: {height[i]}, Weight: {weight[i]}, BMI: {bmi[i]}, Status: {status[i]}");
    }

}

