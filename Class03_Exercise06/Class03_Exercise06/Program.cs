namespace Class03_Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 6");

            Console.WriteLine("Please enter two numbers:");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            

            if (firstNumber == secondNumber)
            {
                Console.Write("You have entered the same number! They are equal!");
                return;
            }
            

            int largerNumber;

            if (firstNumber > secondNumber)
            {
                largerNumber = firstNumber;
            }
            else
            {
                largerNumber = secondNumber;
            }

    
            string evenOrOdd;

            if (largerNumber % 2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }

            Console.WriteLine($"The larger number is number {largerNumber} and it is {evenOrOdd}.");

         
        }
    }
}