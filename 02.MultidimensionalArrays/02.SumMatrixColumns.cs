namespace _02.SumMatrixColumns
{
    internal class Program
    {
        static void Main(string[] args)
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
                    matrix[row,col] = line [col];
                }

            }


            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                    //Console.WriteLine(matrix[row,col] +" ");
                }
                //Console.WriteLine();
                Console.WriteLine(sum);
            }
        }
    }
}
