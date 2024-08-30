namespace Decrypting_Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int lines = int.Parse(Console.ReadLine());
            string message = " ";
            for(int i = 0; i < lines; i++)
            {
                char character = char.Parse(Console.ReadLine());
                char decrypted = (char)(character + key);
                message += decrypted;
            }
            Console.WriteLine(message);
        }
    }
}
