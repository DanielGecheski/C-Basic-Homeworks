namespace Class03_Task02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 2");

            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Daniel", "Risto", "Tijana", "Ana", "Marija" };

            Console.WriteLine("Enter student group (1 or 2):");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.WriteLine("The Students in G1 are:");
                foreach (string student in studentsG1)
                {
                    Console.WriteLine(student);
                }
            }
            else if (input == "2")
            {
                Console.WriteLine("The Students in G2 are:");
                foreach (string student in studentsG2)
                {
                    Console.WriteLine(student);
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}