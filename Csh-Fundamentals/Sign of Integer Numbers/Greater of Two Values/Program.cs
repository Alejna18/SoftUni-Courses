namespace Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int int1 = int.Parse(Console.ReadLine());
            int int2 = int.Parse(Console.ReadLine());
            //int maxInt = Getmax(int1, int2);
            //Console.WriteLine(maxInt);
            char char1 = char.Parse(Console.ReadLine());
            char char2 = char.Parse(Console.ReadLine());
            char maxChar = Getmax(char1, char2);
            Console.WriteLine();
        }
        static char Getmax(char first, char second)
        {
            return first > second ? first : second;
        }
        static string Getmax(string first, string second)
        {
            return String.Compare(first, second) > 0 ? first : second;
        }
    }
}
