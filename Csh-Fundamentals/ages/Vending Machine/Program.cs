using System.Net.Http.Headers;

namespace Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 0m;
            string input;
            while((input = Console.ReadLine()) != "End")
            {
                decimal price = 0m;
                bool product = true;
                switch (input)
                {
                    case "Nuts":
                        price = 2.0m;
                        break;
                    case "Water":
                        price = 0.7m;
                        break;
                    case "Crisps":
                        price = 1.5m;
                        break;
                    case "Soda":
                       price = 0.8m;
                        break;
                    case "Coke":
                       price = 1.0m;
                        break;
                }
                if (product)
                {
                    if (balance >= price)
                    {
                        Console.WriteLine($"Purchased {product}");
                        balance -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    Console.WriteLine($"Change: {balance:F2}");
                }
            }
        }
    }
}
