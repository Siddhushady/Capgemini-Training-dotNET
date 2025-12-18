using System;
using System.Security;

namespace git_Problems
{
    class Calculator
    {
        public static void calculate()
        {
            Console.WriteLine("Calculator \n");

            Console.WriteLine("Enter N1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter N2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int sum = n1 + n2;
            int difference = n1 - n2;
            Console.WriteLine("Sum = " + sum + "\nDifference = " + difference);
        }
    }
}
