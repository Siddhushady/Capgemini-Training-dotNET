using System;

class BMIProgram
{
    static void CalculateBMI(double[,] data)
    {
        for (int i = 0; i < 10; i++)
        {
            double heightM = data[i, 1] / 100;
            data[i, 2] = data[i, 0] / (heightM * heightM);
        }
    }

    static string GetStatus(double bmi)
    {
        if (bmi <= 18.4) return "Underweight";
        if (bmi <= 24.9) return "Normal";
        if (bmi <= 39.9) return "Overweight";
        return "Obese";
    }

    static void Main()
    {
        double[,] data = new double[10, 3];

        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter weight: ");
            data[i, 0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height(cm): ");
            data[i, 1] = Convert.ToDouble(Console.ReadLine());
        }

        CalculateBMI(data);

        for (int i = 0; i < 10; i++)
            Console.WriteLine($"BMI: {data[i, 2]} Status: {GetStatus(data[i, 2])}");
    }
}
