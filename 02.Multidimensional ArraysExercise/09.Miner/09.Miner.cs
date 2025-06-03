namespace _09.Miner
{
    internal class Program
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[size, size];
            int totalCoals = 0;
            int minerRow = 0;
            int minerCol = 0;


            for (int row = 0; row < size; row++)
            {
                char[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    field[row, col] = line[col];
                    if (field[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                    }
                    else if (field[row, col] == 'c')
                    {
                        totalCoals++;
                    }
                }
            }

            int collectedCoals = 0;

            foreach (var command in commands)
            {
                int nextRow = minerRow;
                int nextCol = minerCol;

                switch (command)
                {
                    case "up": nextRow--; break;
                    case "down": nextRow++; break;
                    case "left": nextCol--; break;
                    case "right": nextCol++; break;
                }


                if (nextRow < 0 || nextRow >= size || nextCol < 0 || nextCol >= size)
                {
                    continue;
                }

                minerRow = nextRow;
                minerCol = nextCol;

                if (field[minerRow, minerCol] == 'c')
                {
                    collectedCoals++;
                    field[minerRow, minerCol] = '*';
                    if (collectedCoals == totalCoals)
                    {
                        Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                        return;
                    }
                }
                else if (field[minerRow, minerCol] == 'e')
                {
                    Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                    return;
                }
            }

            Console.WriteLine($"{totalCoals - collectedCoals} coals left. ({minerRow}, {minerCol})");
        }
    }
}