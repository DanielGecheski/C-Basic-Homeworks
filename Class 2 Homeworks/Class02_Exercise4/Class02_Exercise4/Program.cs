namespace Class02_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 4");

            int credit = 102;
            int smsCost = 5;

            float result = credit / (float) smsCost;
            Console.WriteLine($"You can send {result} messages.");
        }
    }
}