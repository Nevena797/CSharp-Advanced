using System;

namespace KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[,] board = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < n; col++)
                {
                    board[row, col] = line[col];
                }
            }

            int removedKnights = 0;


            int[] rowMoves = { -2, -2, -1, -1, 1, 1, 2, 2 };
            int[] colMoves = { -1, 1, -2, 2, -2, 2, -1, 1 };

            while (true)
            {
                int maxAttacks = 0;
                int maxRow = -1;
                int maxCol = -1;

                for (int row = 0; row < n; row++)
                {
                    for (int col = 0; col < n; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            int currentAttacks = CountAttacks(board, row, col, rowMoves, colMoves, n);
                            if (currentAttacks > maxAttacks)
                            {
                                maxAttacks = currentAttacks;
                                maxRow = row;
                                maxCol = col;
                            }
                        }
                    }
                }

                if (maxAttacks == 0)
                {

                    break;
                }


                board[maxRow, maxCol] = '0';
                removedKnights++;
            }

            Console.WriteLine(removedKnights);
        }

        static int CountAttacks(char[,] board, int row, int col, int[] rowMoves, int[] colMoves, int size)
        {
            int attacks = 0;

            for (int i = 0; i < rowMoves.Length; i++)
            {
                int targetRow = row + rowMoves[i];
                int targetCol = col + colMoves[i];

                if (IsInBounds(targetRow, targetCol, size) && board[targetRow, targetCol] == 'K')
                {
                    attacks++;
                }
            }

            return attacks;
        }

        static bool IsInBounds(int row, int col, int size)
        {
            return row >= 0 && row < size && col >= 0 && col < size;
        }
    }
}
