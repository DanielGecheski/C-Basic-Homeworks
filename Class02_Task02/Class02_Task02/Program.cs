namespace Class03_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");

            Console.Write("Enter the First number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the Second number: ");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.Write("Enter the four number: ");
            int fourthNumber = int.Parse(Console.ReadLine());

            int averageNumber = (firstNumber + secondNumber + thirdNumber + fourthNumber) / 4;

            Console.WriteLine("The average of {0}, {1}, {2} and {3} is: {4}", firstNumber, secondNumber, thirdNumber, fourthNumber, averageNumber);
        }
    }
}