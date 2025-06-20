﻿namespace _06._JaggedArrayModification
{

//    3
//1 2 3
//4 5 6 7
//8 9 10
//Add 0 0 5
//Subtract 1 2 2
//Subtract 1 4 7
//END

    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[n][];

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                int[] numbers = Console.ReadLine()
                                       .Split(" ")
                                       .Select(int.Parse)
                                       .ToArray();
                jaggedArray[row] = numbers;
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "END")
                {
                    break;
                }

                string[] tokens = command.Split(" ");
                int row = int.Parse(tokens[1]);
                int i = int.Parse(tokens[2]);

                if (row < 0 || row > jaggedArray.Length - 1 ||
                    i < 0 || i > jaggedArray[row].Length - 1)
                {
                    Console.WriteLine("Invalid coordinates");
                    continue;
                }

                int value = int.Parse(tokens[3]);
                switch (tokens[0])
                {
                    case "Add":
                        jaggedArray[row][i] += value;
                        break;

                    case "Subtract":
                        jaggedArray[row][i] -= value;
                        break;
                }
            }

            foreach (int[] array in jaggedArray)
            {
                Console.WriteLine(String.Join(" ", array));
            }
        }
    }
}