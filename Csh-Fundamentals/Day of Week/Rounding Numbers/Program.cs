using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] num = Console.ReadLine()
                                  .Split(' ')
                                  .Select(double.Parse)
                                  .ToArray();
            foreach(double numbers in num)
            {
                 int rounded = (int)Math.Round(numbers, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{numbers} => {rounded}");
            }
        }
    }
}
