using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();
            int targetNumber = int.Parse(Console.ReadLine());
            for(int i = 0; i < numbers.Length; i++)
            {
                int firstPair = numbers[i];
                for(int j = i + 1; j < numbers.Length; j++)
                {
                    int secondPair = numbers[j];
                    int sumOfPairs = firstPair + secondPair;
                    if (sumOfPairs == targetNumber)
                    {
                        Console.WriteLine($"{firstPair} {secondPair}");
                    }
                }
            }

        }
    }
}
