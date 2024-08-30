namespace Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = n - 1; i >= 1; i--)
            {
                LinePrint(1, i);
            }
            static void LinePrint(int start, int end)
            {
                for (int i = start; i <= end; i++)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
