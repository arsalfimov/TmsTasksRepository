using System.Text.RegularExpressions;

namespace TextManipulation;

public class TextServices
{
    public static void FindWordsWithMaxCountOfDigits(string input)
    {
        List<string> words = GetWords(input);
        int maxDigitsCount = 0;
        List<string> maxDigitWords = new List<string>();

        foreach (string word in words)
        {
            int digitCount = CountDigits(word);
            if (digitCount > maxDigitsCount)
            {
                maxDigitsCount = digitCount;
                maxDigitWords.Clear();
                maxDigitWords.Add(word);
            }
            else if (digitCount == maxDigitsCount)
            {
                maxDigitWords.Add(word);
            }
        }

        Console.WriteLine($"\nWords with the maximum number of digits ({maxDigitsCount}):");
        foreach (string word in maxDigitWords)
        {
            Console.WriteLine(word);
        }
    }

    public static void FindLongestWord(string input)
    {
        List<string> words = GetWords(input);
        var wordCounts = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (!wordCounts.ContainsKey(word))
            {
                wordCounts[word] = 1;
            }
            else
            {
                wordCounts[word]++;
            }
        }

        var longestWord = wordCounts.OrderByDescending(pair => pair.Key.Length).First();
        Console.WriteLine($"\nThe longest word: {longestWord.Key}, number of occurrences: {longestWord.Value}");
    }

    public static void ReplaceDigitsWithWords(ref string input)
    {
        Dictionary<char, string> digitWords = new Dictionary<char, string>
            {
                {'0', "ноль"},
                {'1', "один"},
                {'2', "два"},
                {'3', "три"},
                {'4', "четыре"},
                {'5', "пять"},
                {'6', "шесть"},
                {'7', "семь"},
                {'8', "восемь"},
                {'9', "девять"}
            };

        foreach (var pair in digitWords)
        {
            input = input.Replace(pair.Key.ToString(), pair.Value);
        }

        Console.WriteLine($"\nA string with replaced digits:\n{input}");
    }

    static List<string> GetWords(string input)
    {
        return Regex.Matches(input, @"\b\w+\b")
                    .Cast<Match>()
                    .Select(match => match.Value)
                    .ToList();
    }

    static int CountDigits(string word)
    {
        return word.Count(char.IsDigit);
    }

    public static void DisplayQuestionsFirstThenExclamations(string text)
    {
        string[] sentences = GetSentences(text);

        Console.WriteLine("\nInterrogative sentences:");
        foreach (var sentence in sentences)
        {
            if (!string.IsNullOrWhiteSpace(sentence) && sentence.Trim().EndsWith("?"))
            {
                Console.WriteLine(sentence);
            }
        }

        Console.WriteLine("\nExclamation sentences:");
        foreach (var sentence in sentences)
        {
            if (!string.IsNullOrWhiteSpace(sentence) && sentence.Trim().EndsWith("!"))
            {
                Console.WriteLine(sentence);
            }
        }
    }

    public static void DisplaySentencesWithoutCommas(string text)
    {
        string[] sentences = GetSentences(text);

        var sentencesWithoutCommas = sentences.Where(s => !s.Contains(',')).ToList();

        Console.WriteLine("\nComma-free sentences:");
        foreach (var sentence in sentencesWithoutCommas)
        {
            Console.WriteLine(sentence);
        }
    }

    static string[] GetSentences(string text)
    {
        string pattern = @"(?<=[.!?])\s+";
        return Regex.Split(text, pattern);
    }

    public static void FindWordsWithSameFirstAndLastLetter(string text)
    {
        List<string> words = GetWords(text);
        var wordsWithSameFirstAndLastLetter = words.Where(word => word.Length > 1 && word.ToLower()[0] == word.ToLower()[word.Length - 1]).ToList();

        Console.WriteLine("\nWords starting and ending with the same letter:");
        foreach (var word in wordsWithSameFirstAndLastLetter)
        {
            Console.WriteLine(word);
        }
    }
}