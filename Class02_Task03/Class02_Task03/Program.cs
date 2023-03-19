namespace Class03_Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 3");

            int firstNumber, secondNumber, swapNumbers;

            Console.Write("Input the First Number: ");
            firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the Second Number: ");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            swapNumbers = firstNumber;
            firstNumber = secondNumber;
            secondNumber = swapNumbers;

            Console.WriteLine("Swapped numbers:");
            Console.WriteLine("First Number: {0}", firstNumber);
            Console.WriteLine("Second Number: {0}", secondNumber);
        }
    }
}