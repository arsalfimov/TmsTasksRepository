namespace TextManipulation;

public class Program
{
    static void Main(string[] args)
    {
        string filePath = FileInput.GetValidFilePath();
        string text = File.ReadAllText(filePath);
        Menu.DisplayMenuAndExecuteOptions(text);
    }
}
