namespace Reverse_Array_of_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ');
            Array.Reverse(words);
            Console.WriteLine(string.Join(" ", words));
        }
    }
}
