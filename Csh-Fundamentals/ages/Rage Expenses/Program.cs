namespace Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostcount = int.Parse(Console.ReadLine());
            decimal headsetprice = decimal.Parse(Console.ReadLine());
            decimal mouseprice = decimal.Parse(Console.ReadLine());
            decimal keyboardprice = decimal.Parse(Console.ReadLine());
            decimal displayprice = decimal.Parse(Console.ReadLine());
            int headsettrash = 0;
            int mousetrash = 0;
            int keyboardtrash = 0;
            int displaytrash = 0;
            for (int game = 1; game <= lostcount; game++)
            {
                if (game % 2 == 0) headsettrash++;
                if (game % 3 == 0) mousetrash++;
                if (game % 2 == 0 && game % 3 == 0)
                {
                    keyboardtrash++;
                    if (keyboardtrash % 2 == 0) displaytrash++;
                }
            }
            decimal expenses = (headsettrash * headsetprice) +
                                (mousetrash * mouseprice) +
                                (keyboardtrash * keyboardprice) +
                                (displaytrash * displayprice);
            Console.WriteLine($"Rage expenses: {expenses} lv.");
        }
    }
}
