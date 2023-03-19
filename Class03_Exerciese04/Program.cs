namespace Class03_Exerciese04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4");

            string[] myWords = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            Console.WriteLine(string.Join(",", myWords));
            decimal[] myDecimalValues = { 4.7m, 8.8m, 9.2m, 0.5m, 3.1m };
            Console.WriteLine(string.Join(",", myDecimalValues));
            char[] characters = { 'A', 'B', 'C', 'D', 'E' };
            Console.WriteLine(characters);
            bool[] booleanValues = { true, false, true, false, true };
            Console.WriteLine(string.Join(",", booleanValues));
            int[,] myArray = new int[5, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 }, { 9, 10 } };

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(myArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}