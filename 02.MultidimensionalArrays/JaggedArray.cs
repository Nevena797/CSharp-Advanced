namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //[[ ,  ,  ] [  ,  ,  ] [  ,  ,  ]]
            // [NULL] 
            // [NULL] 
            // [NULL] 
            int[][] jaggedArray = new int[3][]; //[NULL]
            Console.WriteLine(jaggedArray[0]); //NULL

            jaggedArray[0] = new int[1]; //one element
            jaggedArray[0][0] = 1; // on the first row and the first coll index [0] we add value 1

            //Console.WriteLine(jaggedArray[0]); //System.Int32[] -> That is array now
            //Console.WriteLine(jaggedArray[0][0]); // The value of this array ist only one -> 1


            jaggedArray[1] = new int[4]
                {4,5,6,13};

            jaggedArray[2] = new int[3]
            {7,8,9};

            //Console.WriteLine(jaggedArray[0][0]);
            //Console.WriteLine(jaggedArray[1][0]);
            //Console.WriteLine(jaggedArray[1][1]);
            //Console.WriteLine(jaggedArray[1][2]);
            //Console.WriteLine(jaggedArray[1][3]);
            //Console.WriteLine(jaggedArray[1][4]);

            //Console.WriteLine(jaggedArray[row][col]);

            for (int row = 0; row < jaggedArray.Length; row++) // ask how many arrays do you have in
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write(jaggedArray[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
