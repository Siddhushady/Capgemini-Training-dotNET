using System;

class NumberChecker3
{
    static int[] StoreDigits(int number)
    {
        string s = number.ToString();
        int[] digits = new int[s.Length];
        for (int i = 0; i < s.Length; i++)
            digits[i] = s[i] - '0';
        return digits;
    }

    static int[] ReverseArray(int[] arr)
    {
        int[] rev = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
            rev[i] = arr[arr.Length - 1 - i];
        return rev;
    }

    static bool AreEqual(int[] a, int[] b)
    {
        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }

    static bool IsPalindrome(int number)
    {
        int[] digits = StoreDigits(number);
        return AreEqual(digits, ReverseArray(digits));
    }

    static bool IsDuck(int[] digits)
    {
        foreach (int d in digits)
            if (d == 0) return true;
        return false;
    }

    static void Main()
    {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] digits = StoreDigits(number);

        Console.WriteLine("Palindrome: " + IsPalindrome(number));
        Console.WriteLine("Duck Number: " + IsDuck(digits));
    }
}
