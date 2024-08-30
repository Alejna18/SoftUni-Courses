namespace Reversed_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[3];
            for(int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine(i);
                lines[i] = Console.ReadLine();
            }
            Console.WriteLine($"{lines[2]} {lines[1]} {lines[0]}");
        }
    }
}
