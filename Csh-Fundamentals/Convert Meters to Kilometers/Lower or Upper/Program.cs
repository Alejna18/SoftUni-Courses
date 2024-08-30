namespace Lower_or_Upper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char charinput = Console.ReadKey().KeyChar;
            Console.WriteLine();
                if (char.IsUpper(charinput)) 
            {
                Console.WriteLine( "upper-case");
            }
            if (char.IsLower(charinput))
            {
                Console.WriteLine($" lower-case");
            }
        }
    }
}
