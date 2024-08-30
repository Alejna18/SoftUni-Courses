using static System.Runtime.InteropServices.JavaScript.JSType;

namespace even_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number is: {number}");
            }
            else
            {
                Console.WriteLine("Please write an even number.");
            }
        }
    }
}
