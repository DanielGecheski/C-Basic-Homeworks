namespace Class03_Task01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");

            int [] numbers = new int[6];

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Enter integer no.{0}: ", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine("The result is: {0}", sum);
        }
    }
}