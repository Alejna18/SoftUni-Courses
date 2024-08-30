namespace orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ordercount = int.Parse(Console.ReadLine());
            decimal price = 0;
            for(int i = 0; i < ordercount; i++)
            {
                decimal pricepercapsule = decimal.Parse(Console.ReadLine());
                int daysInMonth = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                decimal priceorder = (daysInMonth * capsulesCount) * pricepercapsule;
                price += priceorder;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");
            }
            Console.WriteLine($"Total: ${price:f2}");
        }
    }
}
