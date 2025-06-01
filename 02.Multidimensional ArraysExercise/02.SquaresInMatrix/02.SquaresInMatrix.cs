namespace _02.SquaresInMatrix
{
    internal class Program
    {
        static void Main()
        {
            string[] dimensions = Console.ReadLine().Split(' ');
            int rows = int.Parse(dimensions[0]);
            int cols = int.Parse(dimensions[1]);

            char[,] matrix = new char[rows, cols];


            for (int row = 0; row < rows; row++)
            {
                char[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)[0].ToCharArray();
                string[] symbols = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = symbols[col][0];
                }
            }

            int squareCount = 0;


            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    char current = matrix[row, col];

                    if (current == matrix[row, col + 1] &&
                        current == matrix[row + 1, col] &&
                        current == matrix[row + 1, col + 1])
                    {
                        squareCount++;
                    }
                }
            }
            Console.WriteLine(squareCount);
        }
    }
}
