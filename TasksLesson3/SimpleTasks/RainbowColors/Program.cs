namespace RainbowColors;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the rainbow color number:");

        if (int.TryParse(Console.ReadLine(), out int colorNumber))
        {
            string color = SearchRainbowColor(colorNumber);
            Console.WriteLine($"Rainbow color for number {colorNumber} is {color}");
        }
        else
        {
            Console.WriteLine("Incorrect input.");
        }
    }

    static string SearchRainbowColor(int number)
    {
        switch (number)
        {
            case 1:
                return "Red";
            case 2:
                return "Orange";
            case 3:
                return "Yellow";
            case 4:
                return "Green";
            case 5:
                return "Blue";
            case 6:
                return "Indigo";
            case 7:
                return "Violet";
            default:
                return "Unknown color";
        }
    }
}