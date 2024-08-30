namespace vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            decimal pricepeople = 0;
            decimal discount = 0;
            if (type == "Students")
            {
                discount = 0.15m;
                if (day == "Friday")
                {
                    pricepeople = 8.45m;
                }
                else if (day == "Saturday")
                {
                    pricepeople = 9.80m;
                }
                else if (day == "Sunday")
                {
                    pricepeople = 10.46m;
                }
            }
            if (type == "Business")
            {
                if (people >= 100)
                {
                    people -= 10;
                }

                if (day == "Friday")
                {
                    pricepeople = 10.90m;
                }
                else if (day == "Saturday")
                {
                    pricepeople = 15.60m;
                }
                else if (day == "Sunday")
                {
                    pricepeople = 16;
                }
            }
            if (type == "Regular")
            {
                if (people >= 10 && people <= 20)
                {
                    discount = 0.05m;
                }
                if (day == "Friday")
                {
                    pricepeople = 15;
                }
                else if (day == "Saturday")
                {
                    pricepeople = 20;
                }
                else if (day == "Sunday")
                {
                    pricepeople = 22.50m;
                }
            }
            decimal totalprice = people * pricepeople;
            if (discount > 0)
            {
                totalprice -= totalprice * discount;
            }
            Console.WriteLine($"Total price: {totalprice:f2}");
        }
    }
}