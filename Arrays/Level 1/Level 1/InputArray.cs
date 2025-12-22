using System;

class InputArray
{
    static void Main()
    {
        double[] arr = new double[10];
        double total = 0;
        int index = 0;

        while (true)
        {
            Console.WriteLine("Enter an input nummber: ");
            double value = double.Parse(Console.ReadLine());

            if (value <= 0 || index == 10)
                break;

            arr[index++] = value;
        }

        Console.Write("The array is: [ ");
        for (int i = 0; i < index; i++)
        {
            Console.Write(arr[i] + ", ");
            total += arr[i];
        }
        Console.Write("] \nSum of the array is: " + total + "\n");
    }
}