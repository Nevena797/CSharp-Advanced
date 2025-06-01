namespace _3.PrimaryDiagonal
{
class PrimaryDiagonalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];

            // Read the matrix //3
            for (int row = 0; row < n; row++)
            {
                
                string[] input = Console.ReadLine().Split(); //["11", "2", "4"] - string array
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = int.Parse(input[col]); 
                }
            }

            int sum = 0;

            // Sum the primary diagonal
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine(sum);
        }
    }
}
