namespace Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double maxball = double.MinValue;
            int bestsnow = 0;
            int besttime = 0;
            int bestquality = 0;
            for(int i = 0; i < n; i++)
            {
                int ballsnow = int.Parse(Console.ReadLine());
                int balltime = int.Parse(Console.ReadLine());
                int ballquality = int.Parse(Console.ReadLine());
                double ballvalue = Math.Pow((double)ballsnow / balltime, ballquality);
                if(ballvalue > maxball)
                {
                    maxball = ballvalue;
                    bestsnow = ballsnow;
                    besttime = balltime;
                    bestquality = ballquality;
                }
            }
            Console.WriteLine($"{bestsnow} : {besttime} = {maxball} ({bestquality})");
        
    }
    }
}
