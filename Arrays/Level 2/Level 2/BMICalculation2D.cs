using System;

class BMICalculation2D
{
    public static void Main()
    {
        Console.Write("Enter number of persons: ");
        int n = Convert.ToInt32(Console.ReadLine());

        double[][] personData = new double[n][];
        string[] status = new string[n];

        for (int i = 0; i < n; i++)
        {
            personData[i] = new double[3];

            Console.Write("Enter weight (kg): ");
            personData[i][0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height (m): ");
            personData[i][1] = Convert.ToDouble(Console.ReadLine());

            personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

            status[i] = personData[i][2] < 18.5 ? "Underweight" :
                        personData[i][2] < 25 ? "Normal" :
                        personData[i][2] < 30 ? "Overweight" : "Obese";
        }

        for (int i = 0; i < n; i++)
            Console.WriteLine($"Height: {personData[i][1]}, Weight: {personData[i][0]}, BMI: {personData[i][2]}, Status: {status[i]}");
    }

}
