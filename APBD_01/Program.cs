using System;

class AverageCalculator
{
    public static double CalculateAverage(int[] numbers)
    {
        if (numbers == null || numbers.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        return (double)sum / numbers.Length;
    }

    static void Main()
    {
        int[] testArray = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Average: " + CalculateAverage(testArray));
    }
}