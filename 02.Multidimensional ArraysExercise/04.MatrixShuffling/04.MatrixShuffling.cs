using System;
using System.Linq;

namespace _04.MatrixShuffling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            string[,] matrix = new string[rows, cols];

            // Четем матрицата
            for (int row = 0; row < rows; row++)
            {
                string[] values = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = values[col];
                }
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] token = command.Split(' ');

                if (token[0] == "swap" && token.Length == 5)
                {
                    int row1 = int.Parse(token[1]);
                    int col1 = int.Parse(token[2]);
                    int row2 = int.Parse(token[3]);
                    int col2 = int.Parse(token[4]);

                    if (IsValidIndex(row1, col1, rows, cols) && IsValidIndex(row2, col2, rows, cols))
                    {
                        // Swap
                        string temp = matrix[row1, col1];
                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = temp;

                        // Print matrix
                        PrintMatrix(matrix, rows, cols);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        static bool IsValidIndex(int row, int col, int rows, int cols)
        {
            return row >= 0 && row < rows && col >= 0 && col < cols;
        }

        static void PrintMatrix(string[,] matrix, int rows, int cols)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
