namespace ConsoleCalculator;

public class Program
{
    internal const string EqualsOperator = "=";
    internal const string SqrtOperator = "sqrt";

    static void Main()
    {
        bool continueCalculations = true;

        while (continueCalculations)
        {
            double currentResult = 0;
            string expression = "";

            Console.WriteLine("Welcome to Console Calculator. Enter an expression (to complete, enter '=').");

            while (true)
            {
                if (currentResult == 0)
                {
                    currentResult = InputHandler.GetFirstNumber(ref expression);
                }

                string operation = InputHandler.GetOperation();

                if (operation.ToLower() == EqualsOperator)
                {
                    break;
                }

                try
                {
                    currentResult = Calculator.PerformOperation(currentResult, operation, ref expression);
                }
                catch (Exception ex)
                {
                    Display.HandleError(ex);
                    continue;
                }
            }

            Display.DisplayResultAndExpression(currentResult, expression);

            if (!InputHandler.PromptForContinuation())
            {
                continueCalculations = false;
            }

            Console.Clear();
        }

        Console.WriteLine("The program is completed =).");
    }
}
