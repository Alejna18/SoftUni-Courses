namespace Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = array.Length / 4;
            int[] row1 = new int[2 * k];
            for(int i = 0; i < k; i++)
            {
                row1[i] = array[k - 1 - i];
                row1[k + 1] = array[array.Length - 1 - i];
            }
            int[] row2 = new int[2 * k];
            for(int i = 0; i < 2 * k; i++)
            {
                row2[i] = array[k + i]; 
            }
            int[] rowsum = new int [2 * k];
            for(int i = 0; i < 2 * k; i++)
            {
                rowsum[i] = row1[i] + row2[i]; 
            }
           
            Console.WriteLine(string.Join(" ", rowsum));
        }
    }
}
