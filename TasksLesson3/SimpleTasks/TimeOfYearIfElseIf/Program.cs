namespace TimeOfYearIfElseIf;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the month number (from 1 to 12): ");
        int monthNumber;

        while (!int.TryParse(Console.ReadLine(), out monthNumber) || monthNumber < 1 || monthNumber > 12)
        {
            Console.WriteLine("Incorrect input. Enter the month number from 1 to 12: ");
        }

        string season;

        if (monthNumber == 12 || monthNumber == 1 || monthNumber == 2)
        {
            season = "Winter";
        }
        else if (monthNumber >= 3 && monthNumber <= 5)
        {
            season = "Spring";
        }
        else if (monthNumber >= 6 && monthNumber <= 8)
        {
            season = "Summer";
        }
        else if (monthNumber >= 9 && monthNumber <= 11)
        {
            season = "Autumn";
        }
        else
        {
            season = "Incorrect month. Try again!";
        }

        Console.WriteLine($"The month number: {monthNumber} The season number: {season}");
        Console.ReadKey();
    }
}
