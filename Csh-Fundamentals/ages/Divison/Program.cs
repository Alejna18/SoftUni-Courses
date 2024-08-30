using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Divison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            if(number % 10 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}"); 
            }
            else if(number % 7 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine($"The number is divisible by {number}");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
