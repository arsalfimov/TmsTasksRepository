namespace Matrix;

public class Program
{
    private static void Main()
    {
        int size;

        do
        {
            Console.WriteLine("Enter matrix size:");

            if (int.TryParse(Console.ReadLine(), out size) && size > 0)
            {
                MatrixOperations matrixOperations = new MatrixOperations(size);
                matrixOperations.StartMatrixOperations();
            }
            else
            {
                Console.WriteLine("\nInvalid matrix size. Please enter a positive integer.");
            }

        } while (size <= 0);
    }
}