namespace ConsoleCalculator;

public class Calculator
{
    public static double PerformOperation(double operand1, string operation, ref string expression)
    {
        double result = 0;

        if (operation.Equals(Program.SqrtOperator, StringComparison.CurrentCultureIgnoreCase))
        {
            result = PerformUnaryOperation(operand1, operation);
            expression += $" {operation} = {result}";
        }
        else
        {
            result = PerformBinaryOperation(operand1, operation, ref expression);
        }

        return result;
    }

    public static double PerformBinaryOperation(double operand1, string operation, ref string expression)
    {
        Console.Write("Enter the second number: ");
        string inputSecondNumber = Console.ReadLine();

        double secondNumber;
        if (!double.TryParse(inputSecondNumber, out secondNumber))
        {
            Console.WriteLine("Incorrect input of the second number. Try again.");
            return PerformBinaryOperation(operand1, operation, ref expression);
        }

        double result = CalculateBinaryOperation(operand1, secondNumber, operation);
        expression += $" {operation} {inputSecondNumber} = {result}";

        return result;
    }

    public static double CalculateBinaryOperation(double operand1, double operand2, string operation)
    {
        double result;

        switch (operation)
        {
            case "+":
                result = operand1 + operand2;
                break;
            case "-":
                result = operand1 - operand2;
                break;
            case "*":
                result = operand1 * operand2;
                break;
            case "/":
                if (operand2 == 0)
                {
                    throw new InvalidOperationException("Division by zero is not possible.");
                }
                result = operand1 / operand2;
                break;
            default:
                throw new InvalidOperationException("Invalid operation.");
        }

        Console.WriteLine($"{operand1} {operation} {operand2} = {result}");
        return result;
    }

    static double PerformUnaryOperation(double operand, string operation)
    {
        if (operand < 0 && operation.Equals(Program.SqrtOperator, StringComparison.CurrentCultureIgnoreCase))
        {
            throw new InvalidOperationException("Extracting the square root from a negative number is not possible.");
        }

        double result = Math.Sqrt(operand);
        Console.WriteLine($"{operand} {operation} = {result}");
        return result;
    }
}

