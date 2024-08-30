namespace login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
                Console.WriteLine(i);
            }

        }
    }
}
