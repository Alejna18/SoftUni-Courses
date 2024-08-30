using System.Threading.Channels;

namespace Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double currentbalance = double.Parse(Console.ReadLine());
            double totalspent = 0;
            while (true)
            {
                string game = Console.ReadLine();
                if(game == "Game Time")
                {
                    break;
                }
                double gameprice = 0;
                switch (game)
                {
                    case "OutFall 4":
                        gameprice = 39.99;
                        break;
                    case "CS: OG":
                        gameprice = 15.99;
                        break;
                    case "Zplinter Zell":
                        gameprice = 19.99;
                        break;
                    case "Honored 2":
                        gameprice = 59.99;
                        break;
                    case "RoverWatch":
                        gameprice = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        gameprice = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        continue;
                }
                if(currentbalance >= gameprice)
                {
                    currentbalance -= gameprice;
                    totalspent += gameprice;
                    Console.WriteLine($"Bought {game}");
                }
                if(currentbalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
            }
            Console.WriteLine($"Total spent: ${totalspent:F2}. Remaining: ${currentbalance:F2}");
        }
    }
}
