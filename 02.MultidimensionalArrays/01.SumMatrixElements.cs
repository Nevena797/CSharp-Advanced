namespace _01.SumMatrixElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] lenght = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = lenght[0];
            int cows = lenght[1];

            int[,] matrix = new int[rows, cows];

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cows; col++)
                {
                    matrix[row,col] = line[col];
                }
            }

            int sum = 0;
            for (int row = 0; row < rows; row++)
            {

                for (int col = 0; col < cows; col++)
                {
                    sum += matrix[row,col];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cows);
            Console.WriteLine(sum);

        }
    }
}
