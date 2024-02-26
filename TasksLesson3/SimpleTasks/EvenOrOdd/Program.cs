namespace EvenOrOdd;

internal class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            string result = number % 2 == 0 ? "An even number." : "An odd number.";
            Console.WriteLine(result);

        }
        else
        {
            Console.WriteLine("Input error. Enter an integer.");
        }
    }
}