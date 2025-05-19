void PrintMatrix(int[,] matrix)
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            if (matrix[row, col] < 10)
            {
                Console.Write($"  {matrix[row, col]} ");
            }
            else if (matrix[row, col] < 100)
            {
                Console.Write($" {matrix[row, col]} ");
            }
            else
            {
                Console.Write(matrix[row, col] + " ");
            }
        }
        Console.WriteLine();
    }
}