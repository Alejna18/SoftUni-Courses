namespace Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int capacity = 255;
            int volume = 0;
            int n = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < n; i++)
            {
                int quantities = int.Parse(Console.ReadLine());
                if(volume + quantities > capacity)
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                else
                {
                    volume += quantities;
                }
            }
            Console.WriteLine(volume);
        }
    }
}
