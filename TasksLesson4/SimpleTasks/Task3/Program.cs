namespace Task3;
public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a positive integer: ");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int num) && num > 0)
        {
            int sum = CalculateSumOfNumbers(num);
            Console.WriteLine($"The sum of all numbers from 1 to {num}: {sum}");
        }
        else
        {
            Console.WriteLine("An incorrect number has been entered. Please enter a positive integer...");
        }
    }

    static int CalculateSumOfNumbers(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
}
