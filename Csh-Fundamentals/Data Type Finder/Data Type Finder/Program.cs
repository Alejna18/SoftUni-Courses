namespace Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "END")
                {
                    break;
                }
                Type output = input.GetType();
                Console.WriteLine($"{input} is {input.GetType()} type");
            }
        }
    }
}