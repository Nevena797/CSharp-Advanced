namespace _05._SquareWithMaximumSum1
{
    internal class Program
    {
        static void Main()
        {
            // Четене на размерите
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];

            // Четене на матрицата
            for (int row = 0; row < rows; row++)
            {
                int[] numbers = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;

            // Търсим най-добрата 4x4 подматрица
            for (int row = 0; row <= rows - 4; row++)
            {
                for (int col = 0; col <= cols - 4; col++)
                {
                    int currentSum = 0;

                    // Сумираме текущата 4x4
                    for (int i = row; i < row + 4; i++)
                    {
                        for (int j = col; j < col + 4; j++)
                        {
                            currentSum += matrix[i, j];
                        }
                    }

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }

            // Извеждаме най-добрата 4x4 подматрица
            for (int i = bestRow; i < bestRow + 4; i++)
            {
                for (int j = bestCol; j < bestCol + 4; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);
        }
    }
}