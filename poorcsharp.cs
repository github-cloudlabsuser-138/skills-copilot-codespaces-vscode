using System;

class Program
{
    const int MAX = 100;

    static int Sum(int[] arr)
    {
        int result = 0;
        foreach (int num in arr)
        {
            result += num;
        }
        return result;
    }

    static int ReadInt(string prompt, int min, int max)
    {
        int n;
        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max);
        return n;
    }

    static int[] ReadInts(int count)
    {
        int[] arr = new int[count];
        for (int i = 0; i < count; i++)
        {
            arr[i] = ReadInt($"Enter integer #{i+1}: ", int.MinValue, int.MaxValue);
        }
        return arr;
    }

    static void Main()
    {
        int n = ReadInt("Enter the number of elements (1-100): ", 1, MAX);
        int[] arr = ReadInts(n);
        int total = Sum(arr);
        Console.WriteLine($"Sum of the numbers: {total}");
    }
}