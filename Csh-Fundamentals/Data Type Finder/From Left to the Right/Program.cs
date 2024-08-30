namespace From_Left_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
             for(int i = 0; i < line; i++) 
             {
                string input = Console.ReadLine();
                string[] num = input.Split(' ');
                int leftnum = int.Parse(num[0]);
                int rightnum = int.Parse(num[1]);
                int result;
                if(leftnum > rightnum)
                {
                    result = SumDigits (leftnum);
                }
                else
                {
                    result = SumDigits(rightnum);
                }
                Console.WriteLine(result);
            }
        }
        static int SumDigits(int num)
        {
            int sum = 0;
            while(num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum;
        }
    }
}
