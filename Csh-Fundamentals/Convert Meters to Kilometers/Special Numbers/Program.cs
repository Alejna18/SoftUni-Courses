namespace Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int sum = calculatedigits(i);
                bool special = (sum == 5 || sum == 7 || sum == 11);
               Console.WriteLine($"{i} {special}"); 
                    
            }
            static int calculatedigits(int num)
            {
                int sum = 1;
                while (num > 1)
                {
                    sum += num % 10;
                    num /= 10;
                }
                return sum;
            }
        }
    }
}
