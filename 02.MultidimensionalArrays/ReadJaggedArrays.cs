
int[][] jaggedArray = new int[int.Parse(Console.ReadLine())][];

for (int row = 0; row < jaggedArray.Length; row++)
{
    int[] line = Console.ReadLine().Split().Select(int.Parse).ToArray();

    jaggedArray[row] = new int[line.Length];

    for (int col = 0; col < line.Length; col++)
    {
        jaggedArray[row][col] = line[col];
    }

    //jaggedArray[row] = line;
}
for (int row = 0; row < jaggedArray.Length; row++) 
{
    for (int col = 0; col < jaggedArray[row].Length; col++)
    {
        Console.Write(jaggedArray[row][col] + " ");
    }
    Console.WriteLine();
}
//// Method for reading a jagged array
static int[][] ReadJaggedArray()
{
    // Read the number of rows
    int rows = int.Parse(Console.ReadLine());
    int[][] jagged = new int[rows][];

    // Read the values ​​for each row
    for (int row = 0; row < rows; row++)
    {
        jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
    }

    return jagged;
}

// Using a for loop to output
int[][] matrix = ReadJaggedArray();
for (int row = 0; row < matrix.Length; row++)
{
    for (int col = 0; col < matrix[row].Length; col++)
    {
        Console.Write($"{matrix[row][col]} ");
    }
    Console.WriteLine(); 
}

// Using a foreach loop to output
int[][] jaggedArray = ReadJaggedArray();
foreach (int[] row in jaggedArray)
{
    Console.WriteLine(string.Join(" ", row));
}

// Alternative way to create and display a jagged array
// Set the number of rows
int rowCount = int.Parse(Console.ReadLine());
int[][] jagged = new int[rowCount][];


// Reading the values
for (int row = 0; row < jagged.Length; row++)
{
    jagged[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
}

// Output the array
foreach (int[] row in jagged)
{
    Console.WriteLine(string.Join(" ", row));
}