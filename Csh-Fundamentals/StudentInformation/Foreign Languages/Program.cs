namespace Foreign_Languages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = country switch
            {
                "England" => "English",
                "USA" => "English",
                "Spain" => "Spanish",
                "Argentina" => "Spanish",
                "Mexico" => "Spanish",
                _ => "unknown"
            };
            Console.WriteLine(language);
        }
    }
}
