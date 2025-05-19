namespace _02.SumMatrixRows
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[,] matrix = new int[3, 3]
            {
                {1,2,3 },
                {4,5,6 },
                {7,8,9 }
            };
            for (int col= 0; col < matrix.GetLength(0); col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.GetLength(1); row++)
                {
                    sum += matrix[row, col];
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
                Console.WriteLine(sum);
            }
        }
    }
}