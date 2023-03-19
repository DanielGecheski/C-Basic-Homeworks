namespace Class2_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            Console.WriteLine("Please enter the first number:");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("What operation do you want to do: +, -, * or /):");
            string operation = Console.ReadLine();

            int result;
            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    result = 0;
                    break;
            }
            Console.WriteLine($"The result is: {result}");
        }
    }
}