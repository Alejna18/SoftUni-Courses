namespace Print_Part_of_the_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int last = int.Parse(Console.ReadLine());
            for(int i = start; i <= last; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
