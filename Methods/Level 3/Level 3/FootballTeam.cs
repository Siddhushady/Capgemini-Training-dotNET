using System;

class FootballTeamHeights
{
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int h in heights) sum += h;
        return sum;
    }

    static double FindMean(int[] heights)
    {
        return (double)FindSum(heights) / heights.Length;
    }

    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        foreach (int h in heights)
            if (h < min) min = h;
        return min;
    }

    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        foreach (int h in heights)
            if (h > max) max = h;
        return max;
    }

    static void Main()
    {
        int[] heights = new int[11];
        Random rnd = new Random();

        for (int i = 0; i < heights.Length; i++)
            heights[i] = rnd.Next(150, 251);

        Console.WriteLine("Shortest Height: " + FindShortest(heights));
        Console.WriteLine("Tallest Height: " + FindTallest(heights));
        Console.WriteLine("Mean Height: " + FindMean(heights));
    }
}
