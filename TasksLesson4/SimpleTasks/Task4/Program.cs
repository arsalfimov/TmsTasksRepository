namespace Task4;

public class Program
{
    static void Main(string[] args)
    {
        int startNum = 7;
        int increment = 7;
        int count = 14;

        while (count > 0)
        {
            Console.Write(startNum + " ");

            startNum += increment;
            count--;
        }

        Console.ReadLine();
    }
}
