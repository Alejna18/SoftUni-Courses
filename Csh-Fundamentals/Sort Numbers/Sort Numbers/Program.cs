namespace Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int thirdnum = int.Parse(Console.ReadLine());
            int[] number = { firstnum, secondnum, thirdnum };
            Array.Sort(number);
            Array.Reverse(number);
            for (int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]);
            }
        }
    }
}
