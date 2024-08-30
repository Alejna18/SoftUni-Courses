namespace Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] day = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            int daynum = int.Parse(Console.ReadLine());
            if(daynum >= 1 && daynum <= 7)
            {
                Console.WriteLine(day[daynum - 1]);
            }
            else
            {
                Console.WriteLine("Invalid day!");
            }
        }
    }
}
