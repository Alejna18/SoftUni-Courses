﻿namespace _Equal_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            int[] arr2 = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();
            for(int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }
            }
        }
    }
}
