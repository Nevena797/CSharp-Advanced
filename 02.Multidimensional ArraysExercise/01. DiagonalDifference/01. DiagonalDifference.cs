namespace _01._DiagonalDifference
{
    internal class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            // read the matrix
            for (int row = 0; row < n; row++)
            {
                int[] numbers = Console.ReadLine() //"11 2 4"
                                       .Split(' ')//"11" "2" "4"
                                       .Select(int.Parse) //11 2 4
                                       .ToArray();// [11 2 4]

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            int primarySum = 0;
            int secondarySum = 0;

            // sum diagonals
            for (int i = 0; i < n; i++)
            {
                primarySum += matrix[i, i];              // (0,0), (1,1), (2,2)
                secondarySum += matrix[i, n - 1 - i];   // (0,2), (1,1), (2,0)
            }

            int difference = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(difference);
        }
    }
}