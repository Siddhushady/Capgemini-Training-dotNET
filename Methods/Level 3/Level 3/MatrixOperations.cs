using System;

class MatrixManipulation
{
    static double[,] CreateRandomMatrix(int rows, int cols)
    {
        Random rnd = new Random();
        double[,] matrix = new double[rows, cols];

        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = rnd.Next(1, 10);

        return matrix;
    }

    static void DisplayMatrix(double[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                Console.Write($"{matrix[i, j],6:F2}");
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static double[,] AddMatrices(double[,] a, double[,] b)
    {
        int r = a.GetLength(0);
        int c = a.GetLength(1);
        double[,] result = new double[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = a[i, j] + b[i, j];

        return result;
    }

    static double[,] SubtractMatrices(double[,] a, double[,] b)
    {
        int r = a.GetLength(0);
        int c = a.GetLength(1);
        double[,] result = new double[r, c];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                result[i, j] = a[i, j] - b[i, j];

        return result;
    }

    static double[,] MultiplyMatrices(double[,] a, double[,] b)
    {
        int r1 = a.GetLength(0);
        int c1 = a.GetLength(1);
        int c2 = b.GetLength(1);

        double[,] result = new double[r1, c2];

        for (int i = 0; i < r1; i++)
            for (int j = 0; j < c2; j++)
                for (int k = 0; k < c1; k++)
                    result[i, j] += a[i, k] * b[k, j];

        return result;
    }

    static double[,] TransposeMatrix(double[,] matrix)
    {
        int r = matrix.GetLength(0);
        int c = matrix.GetLength(1);
        double[,] transpose = new double[c, r];

        for (int i = 0; i < r; i++)
            for (int j = 0; j < c; j++)
                transpose[j, i] = matrix[i, j];

        return transpose;
    }

    static double Determinant2x2(double[,] m)
    {
        return (m[0, 0] * m[1, 1]) - (m[0, 1] * m[1, 0]);
    }

    static double Determinant3x3(double[,] m)
    {
        return m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1])
             - m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0])
             + m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
    }

    static double[,] Inverse2x2(double[,] m)
    {
        double det = Determinant2x2(m);
        if (det == 0) return null;

        double[,] inv = new double[2, 2];
        inv[0, 0] = m[1, 1] / det;
        inv[0, 1] = -m[0, 1] / det;
        inv[1, 0] = -m[1, 0] / det;
        inv[1, 1] = m[0, 0] / det;

        return inv;
    }

    static double[,] Inverse3x3(double[,] m)
    {
        double det = Determinant3x3(m);
        if (det == 0) return null;

        double[,] inv = new double[3, 3];

        inv[0, 0] = (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) / det;
        inv[0, 1] = (m[0, 2] * m[2, 1] - m[0, 1] * m[2, 2]) / det;
        inv[0, 2] = (m[0, 1] * m[1, 2] - m[0, 2] * m[1, 1]) / det;

        inv[1, 0] = (m[1, 2] * m[2, 0] - m[1, 0] * m[2, 2]) / det;
        inv[1, 1] = (m[0, 0] * m[2, 2] - m[0, 2] * m[2, 0]) / det;
        inv[1, 2] = (m[0, 2] * m[1, 0] - m[0, 0] * m[1, 2]) / det;

        inv[2, 0] = (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]) / det;
        inv[2, 1] = (m[0, 1] * m[2, 0] - m[0, 0] * m[2, 1]) / det;
        inv[2, 2] = (m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0]) / det;

        return inv;
    }

    static void Main()
    {
        double[,] A = CreateRandomMatrix(3, 3);
        double[,] B = CreateRandomMatrix(3, 3);

        Console.WriteLine("Matrix A:");
        DisplayMatrix(A);

        Console.WriteLine("Matrix B:");
        DisplayMatrix(B);

        Console.WriteLine("Addition:");
        DisplayMatrix(AddMatrices(A, B));

        Console.WriteLine("Subtraction:");
        DisplayMatrix(SubtractMatrices(A, B));

        Console.WriteLine("Multiplication:");
        DisplayMatrix(MultiplyMatrices(A, B));

        Console.WriteLine("Transpose of A:");
        DisplayMatrix(TransposeMatrix(A));

        Console.WriteLine("Determinant of A (3x3): " + Determinant3x3(A));

        double[,] invA = Inverse3x3(A);
        if (invA != null)
        {
            Console.WriteLine("Inverse of A:");
            DisplayMatrix(invA);
        }
        else
            Console.WriteLine("Inverse not possible (Determinant = 0)");
    }
}
