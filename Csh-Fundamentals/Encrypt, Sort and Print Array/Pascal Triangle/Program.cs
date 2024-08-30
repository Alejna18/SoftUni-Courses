namespace Pascal_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numrows = int.Parse(Console.ReadLine());
            int[][] triangle = new int[numrows][];
            for(int i = 0; i < numrows; i++)
            {
                triangle[i] = new int[i + 1];
                triangle[i][0] = 1;
                triangle[i][i] = 1;
                for(int j = 0; j < i; i++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }
            }
            for(int i = 0; i < numrows; i++)
            {
                foreach(int num in triangle[i])
                {
                    Console.WriteLine(num + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
