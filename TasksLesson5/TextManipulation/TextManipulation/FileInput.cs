namespace TextManipulation;

public static class FileInput
{
    public static string GetValidFilePath()
    {
        string filePath;

        do
        {
            filePath = PromptFilePath();

            if (!string.IsNullOrWhiteSpace(filePath) && !FileExists(filePath))
            {
                Console.WriteLine("The file was not found. Please enter the correct file path.");
            }
            else if (!string.IsNullOrWhiteSpace(filePath) && FileIsEmpty(filePath))
            {
                Console.WriteLine("The file is empty. Please select another file.");
            }

        } while (string.IsNullOrWhiteSpace(filePath) || !FileExists(filePath) || FileIsEmpty(filePath));

        return filePath;
    }

    static string PromptFilePath()
    {
        Console.WriteLine("Enter the path to the text file:");
        Console.WriteLine("You can try \"Test.txt\"");
        return Console.ReadLine();
    }

    static bool FileExists(string filePath)
    {
        return File.Exists(filePath);
    }

    static bool FileIsEmpty(string filePath)
    {
        return string.IsNullOrWhiteSpace(File.ReadAllText(filePath));
    }
}
