using System.Net.WebSockets;

namespace print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startnum = int.Parse(Console.ReadLine());
            int endnum = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = startnum; i <= endnum; i++)
            {
                Console.Write(i + " ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}