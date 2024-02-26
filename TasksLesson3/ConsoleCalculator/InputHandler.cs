namespace ConsoleCalculator;

public static class InputHandler
{
    public static double GetFirstNumber(ref string expression)
    {
        Console.Write("Enter the first number: ");
        string inputFirstNumber = Console.ReadLine();

        if (inputFirstNumber.Equals(Program.EqualsOperator, StringComparison.CurrentCultureIgnoreCase))
        {
            return 0;
        }

        double firstNumber;
        if (!double.TryParse(inputFirstNumber, out firstNumber))
        {
            Console.WriteLine("Incorrect number input. Try again.");
            return GetFirstNumber(ref expression);
        }

        expression += inputFirstNumber;
        return firstNumber;
    }

    public static string GetOperation()
    {
        Console.Write("Enter the operation (+, -, *, /, sqrt, =): ");
        return Console.ReadLine();
    }

    public static bool PromptForContinuation()
    {
        Console.Write("\nWould you like to continue the calculations? (yes/no): ");
        string continueInput = Console.ReadLine().ToLower();

        if (continueInput == "yes")
        {
            return true;
        }
        else if (continueInput == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            return PromptForContinuation();
        }
    }
}

