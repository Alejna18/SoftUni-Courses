namespace __Math_Power
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RaisePower(number, power);
            Console.WriteLine(result);
        }
        static double RaisePower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
