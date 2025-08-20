using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] transactions = { 200, -150, 340, 500, -100 };
        int sum = 0;
        foreach (int t in transactions)
            sum += t;
        Console.WriteLine("Q1: Sum = " + sum);

        float[] scores = { 85.5f, 90.3f, 78.4f, 88.9f, 92.1f };
        float total = 0;
        foreach (float s in scores)
            total += s;
        Console.WriteLine("Q2: Average = " + (total / scores.Length));

        int[] prices = { 1500, 2300, 999, 3200, 1750 };
        int max = prices[0];
        foreach (int p in prices)
            if (p > max) max = p;
        Console.WriteLine("Q3: Largest = " + max);

        int[] participantCodes = { 102, 215, 324, 453, 536 };
        int evenCount = 0, oddCount = 0;
        foreach (int code in participantCodes)
        {
            if (code % 2 == 0) evenCount++;
            else oddCount++;
        }
        Console.WriteLine($"Q4: Even = {evenCount}, Odd = {oddCount}");

        int[] searchHistory = { 101, 202, 303, 404, 505 };
        Console.Write("Q5: Reversed = ");
        for (int i = searchHistory.Length - 1; i >= 0; i--)
            Console.Write(searchHistory[i] + " ");
        Console.WriteLine();

        int[] measurements = { 2, 4, 6, 8 };
        int factor = 3;
        Console.Write("Q6: Multiplied = ");
        for (int i = 0; i < measurements.Length; i++)
            Console.Write(measurements[i] * factor + " ");
        Console.WriteLine();

        int[] bookCodes = { 101, 203, 304, 405, 506 };
        int searchCode = 304;
        int index = -1;
        for (int i = 0; i < bookCodes.Length; i++)
            if (bookCodes[i] == searchCode) index = i;
        Console.WriteLine("Q7: Index of " + searchCode + " = " + index);

        int[] grades = { 56, 78, 89, 45, 67 };
        Array.Sort(grades);
        Console.WriteLine("Q8: Second smallest = " + grades[1]);

        int[] ids = { 102, 215, 102, 324, 215 };
        HashSet<int> uniqueIds = new HashSet<int>(ids);
        Console.Write("Q9: Unique IDs = ");
        foreach (int id in uniqueIds)
            Console.Write(id + " ");
        Console.WriteLine();

        int[] dataset1 = { 1, 2, 3, 4, 5 };
        int[] dataset2 = { 3, 4, 5, 6, 7 };
        Console.Write("Q10: Common elements = ");
        foreach (int d1 in dataset1)
            foreach (int d2 in dataset2)
                if (d1 == d2) Console.Write(d1 + " ");
        Console.WriteLine();
    }
}
