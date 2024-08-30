namespace Refactoring_Prime_Checker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 2; i <= num; i++)
            {
                bool corect  = true;
                for (int cepitel = 2; cepitel < i; cepitel++)
                {
                    if (i % cepitel == 0)
                    {
                        corect = false;
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, corect);
            }

        }
    }
}