namespace TextManipulation;

public static class Menu
{
    public static void DisplayMenuAndExecuteOptions(string text)
    {
        while (true)
        {
            DisplayMenu();

            string choice = Console.ReadLine().Trim();

            switch (choice)
            {
                case "1":
                    TextServices.FindWordsWithMaxCountOfDigits(text);
                    break;
                case "2":
                    TextServices.FindLongestWord(text);
                    break;
                case "3":
                    TextServices.ReplaceDigitsWithWords(ref text);
                    break;
                case "4":
                    TextServices.DisplayQuestionsFirstThenExclamations(text);
                    break;
                case "5":
                    TextServices.DisplaySentencesWithoutCommas(text);
                    break;
                case "6":
                    TextServices.FindWordsWithSameFirstAndLastLetter(text);
                    break;
                case "7":
                    return;
                default:
                    Console.WriteLine("Wrong choice. Try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("\n_Selection Menu_:");
        Console.WriteLine("1. Find words containing the maximum number of digits.");
        Console.WriteLine("2. Find the longest word and determine how many times it has appeared in the text.");
        Console.WriteLine("3. Replace the numbers from 0 to 9 with the words «ноль», «один», …, «девять».");
        Console.WriteLine("4. Display first interrogative and then exclamation sentences on the screen.");
        Console.WriteLine("5. Display only sentences that do not contain commas.");
        Console.WriteLine("6. Find words starting and ending with the same letter.");
        Console.WriteLine("7. Exit the program.");
        Console.Write("\nSelect an action (1-7): ");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
