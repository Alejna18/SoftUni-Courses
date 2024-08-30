namespace Centuries_to_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            const int yearsCentury = 100;
            const int daysYear = 365;
            const int hoursday = 24;
            const int minuteshour = 60;
            int years = centuries * yearsCentury;
            int days = years * daysYear;
            int hours = days * hoursday;
            int minutes = hours * minuteshour;
            Console.WriteLine($"{centuries} centuries are equivalent to:");
            Console.WriteLine($"{years} years");
            Console.WriteLine($"{days} days");
            Console.WriteLine($"{hours} hours");
            Console.WriteLine($"{minutes} minutes");
        }
    }
}
