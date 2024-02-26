namespace Matrix;

public class MatrixOperations
{
    private readonly int[,] matrix;
    private readonly int size;

    public MatrixOperations(int size)
    {
        this.size = size;
        matrix = GenerateMatrix(size);
    }

    private int[,] GenerateMatrix(int size)
    {
        int[,] generatedMatrix = new int[size, size];
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                generatedMatrix[i, j] = random.Next(-50, 51);
            }
        }

        return generatedMatrix;
    }

    public void StartMatrixOperations()
    {
        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Find the number of positive/negative numbers in a matrix");
            Console.WriteLine("2. Sorting matrix elements row by row (List)");
            Console.WriteLine("3. Inverting matrix elements row by row");
            Console.WriteLine("4. Print matrix");
            Console.WriteLine("5. Exit");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                UserChoiceProcess(choice);
            }
            else
            {
                Console.WriteLine("\nWrong choice. Please select again.");
            }
        }
    }

    private void UserChoiceProcess(int choice)
    {
        switch (choice)
        {
            case 1:
                CountPositiveOrNegative();
                break;
            case 2:
                SortMatrix();
                break;
            case 3:
                InvertMatrix();
                break;
            case 4:
                PrintMatrix();
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("\nWrong choice. Please select again.");
                break;
        }
    }

    private void CountPositiveOrNegative()
    {
        int positiveCount = 0;
        int negativeCount = 0;

        foreach (var element in matrix)
        {
            if (element > 0)
                positiveCount++;
            else if (element < 0)
                negativeCount++;
        }

        Console.WriteLine($"\nNumber of positive numbers: {positiveCount}");
        Console.WriteLine($"Number of negative numbers: {negativeCount}");
    }

    private void SortMatrix()
    {
        Console.WriteLine("\nSelect sort direction:");
        Console.WriteLine("1. Row by row in ascending order");
        Console.WriteLine("2. Row by row in descending order");
        Console.WriteLine("3. By columns in ascending order");
        Console.WriteLine("4. By columns in descending order");

        if (int.TryParse(Console.ReadLine(), out int sortChoice))
        {
            switch (sortChoice)
            {
                case 1:
                    SortRowsAscending();
                    break;
                case 2:
                    SortRowsDescending();
                    break;
                case 3:
                    SortColumnsAscending();
                    break;
                case 4:
                    SortColumnsDescending();
                    break;
                default:
                    Console.WriteLine("\nInvalid sort selection. Please select again.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("\nInvalid sort selection. Please select again.");
        }
    }

    private void SortRowsAscending()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
                {
                    if (matrix[i, k] > matrix[i, k + 1])
                    {
                        SwapElements(i, k, k + 1);
                    }
                }
            }
        }

        Console.WriteLine("\nMatrix sorted by rows in ascending order.");
    }

    private void SortRowsDescending()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int k = 0; k < matrix.GetLength(1) - 1 - j; k++)
                {
                    if (matrix[i, k] < matrix[i, k + 1])
                    {
                        SwapElements(i, k, k + 1);
                    }
                }
            }
        }

        Console.WriteLine("\nMatrix sorted by rows in descending order.");
    }

    private void SortColumnsAscending()
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(0) - 1 - i; k++)
                {
                    if (matrix[k, j] > matrix[k + 1, j])
                    {
                        SwapElements(k, j, k + 1, j);
                    }
                }
            }
        }

        Console.WriteLine("\nMatrix sorted by columns in ascending order.");
    }

    private void SortColumnsDescending()
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int k = 0; k < matrix.GetLength(0) - 1 - i; k++)
                {
                    if (matrix[k, j] < matrix[k + 1, j])
                    {
                        SwapElements(k, j, k + 1, j);
                    }
                }
            }
        }

        Console.WriteLine("\nMatrix sorted by columns in descending order.");
    }

    private void InvertMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1) / 2; j++)
            {
                SwapElements(i, j, matrix.GetLength(1) - 1 - j);
            }
        }

        Console.WriteLine("\nThe matrix is ​​inverted row by row.");
    }

    private void SwapElements(int row, int col1, int col2)
    {
        int temp = matrix[row, col1];
        matrix[row, col1] = matrix[row, col2];
        matrix[row, col2] = temp;
    }

    private void SwapElements(int row1, int col1, int row2, int col2)
    {
        int temp = matrix[row1, col1];
        matrix[row1, col1] = matrix[row2, col2];
        matrix[row2, col2] = temp;
    }

    private void PrintMatrix()
    {
        Console.ForegroundColor = ConsoleColor.Red;

        Console.WriteLine("\nMatrix:");

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j],4}");
            }
            Console.WriteLine();
        }

        Console.ResetColor();
    }
}
