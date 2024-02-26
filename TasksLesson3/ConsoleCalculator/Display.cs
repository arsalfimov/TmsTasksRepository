namespace ConsoleCalculator;

public class Display
{
    public static void DisplayResultAndExpression(double currentResult, string expression)
    {
        Console.WriteLine($"Result: {currentResult}");
        Console.WriteLine($"Full expression: {expression}");
    }
    public static void HandleError(Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}. Try again.");
    }
}

