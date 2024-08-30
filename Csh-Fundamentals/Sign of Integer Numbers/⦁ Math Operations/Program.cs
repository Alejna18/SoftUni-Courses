namespace __Math_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstnumber = double.Parse(Console.ReadLine());
            char operation = char.Parse(Console.ReadLine());
            double secondnumber = double.Parse(Console.ReadLine());
            double result = Calculate(firstnumber, secondnumber, operation);
            Console.WriteLine(result);
        }
        static double Calculate(double num1, double num2, char op)
        {
            switch (op)
            {
                case '+':
                    return num1 + num2;
                case '-':
                    return num1 - num2;
                case '*':
                    return num1 * num2;
                case '/':
                    
                    if (num2 != 0)
                    {
                        return num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return double.NaN;
                    }
                default:
                    Console.WriteLine("Error: Invalid operator.");
                    return double.NaN;
            }
        }
    }
}
