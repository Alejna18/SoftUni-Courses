namespace __Longest_Increasing_Subsequence__LIS_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums.Length;
            int[] len = new int[n];
            int[] prev = new int[n];
            for(int i = 0; i < n; i++)
            {
                len[i] = 1;
                prev[i] = -1;
            }
            for(int p = 1; p < n; p++)
            {
                for(int left = 0; left < p; left++)
                {
                    if (nums[left] < nums[p] && len[left] + 1 > len[p])
                    {
                    len[p] = len[left] + 1;
                    prev[p] = left;
                    }
                }
            }
            int maxLen = len.Max();
            int maxIndex = Array.IndexOf(len, maxLen);
            List<int> lis = new List<int>();
            while (maxIndex != -1)
            {
                lis.Add(nums[maxIndex]);
                maxIndex = prev[maxIndex];
            }

            
            lis.Reverse();

           
            Console.WriteLine(string.Join(" ", lis));
        }
    }
}
