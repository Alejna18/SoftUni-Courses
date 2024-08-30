namespace Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            if(n < 1 || n > 50)
            {
                return;
            }
            int result = Fibonachi(n);
            Console.WriteLine(result);
        }
        static int Fibonachi(int n)
        {
            if(n == 1 || n == 2)
            {
                return 1;
            }
            return Fibonachi(n - 1) + Fibonachi(n - 2);
        }
    }
}
