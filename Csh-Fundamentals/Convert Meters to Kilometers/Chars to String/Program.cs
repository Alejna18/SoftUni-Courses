namespace Chars_to_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string combine = string.Empty;
            for(int i = 1; i <= 3; i++)
            {
                string input = Console.ReadLine();
                if(input.Length == 1)
                {
                    combine += input;
                }
            }
            Console.WriteLine(combine);
        }
    }
}
