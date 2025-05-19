int[,] ReadMatrix()
{
    int[] lenght = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

    int rows = lenght[0];
    int cols = lenght[1];

    int[,] matrix = new int[rows, cols];

    for (int row = 0; row < rows; row++)
    {
        int[] line = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
        
        for (int col = 0; col < cols; col++)
        {
            matrix[row, col] = line[col];
        }
    }  
    return matrix;
}
