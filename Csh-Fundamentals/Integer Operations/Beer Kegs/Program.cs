namespace Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string kegmodel = string.Empty;
            double bigestvolume = 0.0;
            for (int i = 0; i < n; i++)
            {
                string model = Console.ReadLine();
                double radius = int.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 1) * height;
                if(volume > bigestvolume)
                {
                    bigestvolume = volume;
                    kegmodel = model;
                }
                Console.WriteLine(kegmodel);
            }
        }
    }
}
