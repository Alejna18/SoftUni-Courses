namespace __Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(str, count);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int count)
        {
            return String.Concat(Enumerable.Repeat(str, count));
        }
    }
}
