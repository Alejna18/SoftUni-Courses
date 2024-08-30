namespace Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal pounds = int.Parse(Console.ReadLine());
            decimal converting = 1.31m;
            decimal dollars = pounds * converting;
            Console.WriteLine($"{dollars:f3}");
        }
    }
}
