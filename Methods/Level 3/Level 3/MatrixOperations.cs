using System;

class MatrixOperations
{
    static int[,] CreateMatrix(int r, int c)
    {
        Random rnd = new Random();
        int[,] m = new int[r, c];
        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                m[i, j] = rnd.Next(1, 10);
        return m;
    }

    static void Display(int[,] m)
    {
        for (int i = 0; i < m.GetLength(0); i++)
        {
            for (int j = 0; j < m.GetLength(1); j++)
                Console.Write(m[i, j] + " ");
            Console.WriteLine();
        }
    }

    static void Main()
    {
        int[,] a = CreateMatrix(2, 2);
        Display(a);
    }
}
