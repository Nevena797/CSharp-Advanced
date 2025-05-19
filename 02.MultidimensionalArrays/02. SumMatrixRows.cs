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
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int sum = 0;

                for (int col = 0; col < matrix.GetLength(1); col++) 
                {
                    sum += matrix[row, col]; 
                }
                Console.WriteLine(sum);
            }
        }
    }
}
