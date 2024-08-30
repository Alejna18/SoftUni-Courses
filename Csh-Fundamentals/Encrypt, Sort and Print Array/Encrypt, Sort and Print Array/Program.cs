namespace Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] encryptedvalues = new int[n];
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                int Lenght = input.Length;
                int stringLength = input.Length;
                int encryptedValue = 0;
                foreach(char ch in input)
                {
                    if ("aeiouAEIOU".Contains(ch))
                    { 
                        encryptedValue += ch * stringLength;
                    }
                    else
                    {
                        encryptedValue += ch / stringLength;
                    }
                    encryptedvalues[i] = encryptedValue;
                }
            }
            Array.Sort(encryptedvalues);
            foreach (int value in encryptedvalues)
            {
                Console.WriteLine(value);
            }

        }
    }
}
