namespace Class03_Exercise03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 3");

            Console.WriteLine("Please enter a number:");
            int myNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <= myNumber; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(i);
                }

                if (i == 100)
                {
                    Console.WriteLine("The limit is reached! Stop counting.");
                    break;
                }
            }
        }
    }
}