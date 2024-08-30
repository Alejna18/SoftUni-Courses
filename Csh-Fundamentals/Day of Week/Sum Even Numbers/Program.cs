namespace Sum_Even_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                    .Split(' ')
                                    .Select(int.Parse)
                                    .ToArray();
            int evensum = 0;
            int oddsum = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                int currentnum = numbers[i];
                if(currentnum % 2 == 0)
                {
                    evensum += currentnum;
                }
                else
                {
                    oddsum += currentnum;
                }
                int differene = evensum - oddsum;
                Console.WriteLine(differene);
            }
        }
    }
}
