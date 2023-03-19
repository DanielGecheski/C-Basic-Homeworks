namespace Class03_Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise 5");

            int[] myArray = new int[5];

            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write("Please enter the value of element: {0} ", i);
                myArray[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;

            foreach (int number in myArray)
            {
                sum += number;
            }

            Console.WriteLine("The sum of all the values is: {0}", sum);
        }
    }
}