namespace _05.SquareWithMaximumSum
{
    internal class Program
    {
        static void Main()
        {
            int[] sizes = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = sizes[0];
            int cols = sizes[1];

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                int[] inputRow = Console.ReadLine()
                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = inputRow[col];
                }
            }

            int maxSum = int.MinValue;
            int bestRow = 0;
            int bestCol = 0;


            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    int currentSum =
                        matrix[row, col] + matrix[row, col + 1] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        bestRow = row;
                        bestCol = col;
                    }
                }
            }
            Console.WriteLine($"{matrix[bestRow, bestCol]} {matrix[bestRow, bestCol + 1]}");
            Console.WriteLine($"{matrix[bestRow + 1, bestCol]} {matrix[bestRow + 1, bestCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}