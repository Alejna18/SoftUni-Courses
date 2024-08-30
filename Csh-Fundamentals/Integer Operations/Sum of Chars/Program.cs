namespace Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());
            for(int i = 0; i < lines; i++)
            {
                Console.WriteLine(i + 1);
                char letters = char.Parse(Console.ReadLine());
                sum += (int)letters;
            }
            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
