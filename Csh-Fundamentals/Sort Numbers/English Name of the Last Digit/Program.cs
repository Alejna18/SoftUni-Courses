using static System.Runtime.InteropServices.JavaScript.JSType;

namespace English_Name_of_the_Last_Digit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string lastdigit = Englishspelling(num);
            Console.WriteLine(lastdigit);
        }
        static string Englishspelling(int num)
        {
            int lastDigit = Math.Abs(num % 10);
            switch (lastDigit)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }
    }
}
