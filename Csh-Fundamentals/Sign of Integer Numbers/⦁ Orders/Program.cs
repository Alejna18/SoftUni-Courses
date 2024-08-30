namespace __Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            totalprice(product, quantity);
        }
        static void totalprice(string product, int quantity)
        {
            decimal price = 0.0m;
            switch (product)
            {
                case "coffee":
                    price = 1.50m;
                    break;
                case "water":
                    price = 1.00m;
                    break;
                case "coke":
                    price = 1.40m;
                    break;
                case "snacks":
                    price = 2.00m;
                    break;
            }
            decimal total = price * quantity;
            Console.WriteLine(total);
        }
    }
}
