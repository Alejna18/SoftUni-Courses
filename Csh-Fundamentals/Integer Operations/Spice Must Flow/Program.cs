using System.Xml;

namespace Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int starrtingyield = int.Parse(Console.ReadLine());
            int total = 0;
            int day = 0;
            while(starrtingyield >= 100)
            {
                total += starrtingyield;
                total -= 26;
                starrtingyield -= 10;
                day++;
            }
            if(total >= 26)
            {
                total -= 26;
            }
            Console.WriteLine(day);
            Console.WriteLine(total);
        }
    }
}
