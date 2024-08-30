namespace Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstnum = int.Parse(Console.ReadLine());
            int secondnum = int.Parse(Console.ReadLine());
            int thirdnum = int.Parse(Console.ReadLine());
            int fourtnum = int.Parse(Console.ReadLine());
            int sum = firstnum + secondnum;
            int division = sum / thirdnum;
            int result = division * fourtnum;
            Console.WriteLine(result);
        }
    }
}
