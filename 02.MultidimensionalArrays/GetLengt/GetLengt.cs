using System;

class Program
{
    static void Main()
    {
        int[,] matrix = new int[3, 4]; // 3 row, 4 cow

        Console.WriteLine("matrix.Length = " + matrix.Length);               // Total items
        Console.WriteLine("matrix.GetLength(0) = " + matrix.GetLength(0));  // rows
        Console.WriteLine("matrix.GetLength(1) = " + matrix.GetLength(1));  // cols

        
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = row + col; 
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}