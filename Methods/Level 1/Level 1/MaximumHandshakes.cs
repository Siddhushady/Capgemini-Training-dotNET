using System;

class HandshakeProgram
{
    static int CalculateHandshakes(int n)
    {
        return (n * (n - 1)) / 2;
    }

    static void Main()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"Maximum number of handshakes: {CalculateHandshakes(n)}");
    }
}
