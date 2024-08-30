namespace Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int line = int.Parse(Console.ReadLine());
            int balance = 0;
            bool isBalanced = true;
            for(int i = 0; i < line; i++)
            {
                string input = Console.ReadLine();
                if(input == "(")
                {
                    if(balance > 0)
                    {
                        isBalanced = false;
                        break;
                    }
                    balance++;
                }
                else if(input == ")")
                {
                    if(balance == 0)
                    {
                        isBalanced = false; 
                        break;
                    }
                    balance--;
                }
                if(isBalanced && balance == 0)
                {
                    Console.WriteLine("BALANCED");
                }
                else
                {
                    Console.WriteLine("UNBALANCED");
                }
            }
        }
    }
}
