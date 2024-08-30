using System.Threading.Channels;

namespace __Printing_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Triangle(num);
        }
        static void printline(int start, int end)
        {
            for(int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        static void Triangle(int num)
        {
            for(int i = 1; i <= num; i++)
            {
                printline(1, i);
            }
            for (int i = num - 1; i >= 1; i--) 
            {
                printline(1, i);
            }
            
        }
      
    }
}
