using System.Data;

namespace _08.Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                int[] row = Console.ReadLine()
                                   .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                   .Select(int.Parse)
                                   .ToArray();
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = row[j];
                }
            }
            string[] bombs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (string bomb in bombs)
            {
                int[] coords = bomb.Split(',').Select(int.Parse).ToArray();
                int row = coords[0];
                int col = coords[1];

                int bombValue = matrix[row, col];
                if (bombValue <= 0)
                {
                    continue;
                }
                for (int i = row - 1; i <= row + 1; i++)
                {
                    for (int j = col - 1; j <= col + 1; j++)
                    {
                        if (i >= 0 && i < n && j >= 0 && j < n)
                        {
                            if (matrix[i, j] > 0)
                            {
                                matrix[i, j] -= bombValue;
                            }
                        }
                    }
                }
                matrix[row, col] = 0;
            }
            int aliveCells = 0;
            int sumAlive = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        aliveCells++;
                        sumAlive += matrix[i, j];
                    }
                }
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumAlive}");


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}