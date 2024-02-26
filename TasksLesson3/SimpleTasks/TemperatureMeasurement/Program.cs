namespace TemperatureMeasure;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the temperature:");
        if (int.TryParse(Console.ReadLine(), out int temperature))
        {
            if (temperature > -5)
            {
                Console.WriteLine("Warm");
            }
            else if (temperature > -20)
            {
                Console.WriteLine("Normally");
            }
            else
            {
                Console.WriteLine("Сoldly");
            }
        }
        else
        {
            Console.WriteLine("Input error. Please enter an integer.");
        }
    }
}
