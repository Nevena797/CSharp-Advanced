namespace RemoveEmptyEntries
{
    internal class RemoveEmptyEntries
    {
        static void Main(string[] args)
        {
            //string input = "a,,b,c,";
            //string[] parts = input.Split(',', StringSplitOptions.None);
            //foreach (var part in parts)
            //{
            //    Console.WriteLine($"[{part}]");
            //    //[a]
            //    //[]
            //    //[b]
            //    //[c]
            //    //[]
            //}
            string input = "a,,b,c,";
            string[] parts = input.Split(',', StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in parts)
            {
                Console.WriteLine($"[{part}]");
            }
        }
    }
}
