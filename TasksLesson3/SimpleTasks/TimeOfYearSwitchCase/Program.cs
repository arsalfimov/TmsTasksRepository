namespace TimeOfYearSwitchCase;

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
        switch (monthNumber)
        {
            case 12:
            case 1:
            case 2:
                season = "Winter";
                break;
            case 3:
            case 4:
            case 5:
                season = "Spring";
                break;
            case 6:
            case 7:
            case 8:
                season = "Summer";
                break;
            case 9:
            case 10:
            case 11:
                season = "Autumn";
                break;
            default:
                season = "Incorrect month. Try again!";
                break;
        }

        Console.WriteLine($"The month number: {monthNumber} The season number: {season}");
        Console.ReadKey();
    }
}
