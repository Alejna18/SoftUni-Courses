namespace Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            checknumber(number);
        }
        static void checknumber(int number)
        {
            if(number > 0)
            {
                Console.WriteLine($"The number {number} is positive. ");
            }
            if(number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero. ");
            }
        }
    }
}
