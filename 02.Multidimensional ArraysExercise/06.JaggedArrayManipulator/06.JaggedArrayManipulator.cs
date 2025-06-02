using System.Data;

namespace _06.JaggedArrayManipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double[][] jagged = new double[n][];


            for (int row = 0; row < n; row++)
            {
                jagged[row] = Console.ReadLine() //Input: 10 20 30 //jagged[0] = [10, 20, 30]
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
            }


            for (int row = 0; row < n - 1; row++)
            {
                if (jagged[row].Length == jagged[row + 1].Length)
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] *= 2;
                        jagged[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jagged[row].Length; col++)
                    {
                        jagged[row][col] /= 2;
                    }
                    for (int col = 0; col < jagged[row + 1].Length; col++)
                    {
                        jagged[row + 1][col] /= 2;
                    }
                }
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = parts[0];
                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);
                int value = int.Parse(parts[3]);

                if (row >= 0 && row < n && col >= 0 && col < jagged[row].Length)
                {
                    if (action == "Add")
                    {
                        jagged[row][col] += value;
                    }
                    else if (action == "Subtract")
                    {
                        jagged[row][col] -= value;
                    }
                }
            }

            for (int row = 0; row < jagged.Length; row++)
            {
                for (int col = 0; col < jagged[row].Length; col++)
                {
                    Console.Write((int)jagged[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}