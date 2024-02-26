namespace Task5;

public class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int[] mas1 = new int[5];
        Console.WriteLine("Array 1:");
        RandomNumbers(mas1, random);
        DisplayArray(mas1);

        int[] mas2 = new int[5];
        Console.WriteLine("\nArray 2:");
        RandomNumbers(mas2, random);
        DisplayArray(mas2);

        double avg1 = CalculateAvg(mas1);
        double avg2 = CalculateAvg(mas2);

        int sum1 = CalculateSum(mas1);
        int sum2 = CalculateSum(mas2);


        Console.WriteLine($"\nSum of Array 1: {sum1}");
        Console.WriteLine($"Sum of Array 2: {sum2}");

        Console.WriteLine($"\nAverage of Array 1: {avg1}");
        Console.WriteLine($"Average of Array 2: {avg2}");

        if (avg1 > avg2)
        {
            Console.WriteLine("\nThe average of Array 1 is greater than the average of Array 2.");
        }
        else if (avg1 < avg2)
        {
            Console.WriteLine("\nThe average of Array 2 is greater than the average of Array 1.");
        }
        else
        {
            Console.WriteLine("\nThe averages of both arrays are equal.");
        }
    }

    static void RandomNumbers(int[] array, Random random)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(-5, 5);
        }
    }

    static void DisplayArray(int[] array)
    {
        foreach (var number in array)
        {
            Console.Write($"{number} ");
        }
        Console.WriteLine();
    }

    static double CalculateAvg(int[] array)
    {
        int sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }
        return (double)sum / array.Length;
    }
    static int CalculateSum(int[] array)
    {
        int sum = 0;
        foreach (var number in array)
        {
            sum += number;
        }
        return sum;
    }
}