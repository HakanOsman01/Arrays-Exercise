using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToArray();
            int maxSequnce = int.MinValue;
            int count = 0;
            int mostFrequentElement = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] != numbers[i + 1])
                {
                    count = 0;
                    continue;
                }
                count++;
                if (count > maxSequnce)
                {
                    maxSequnce = count;
                    mostFrequentElement = numbers[i];
                }

            }
            for(int i = 0; i <= maxSequnce; i++)
            {
                Console.Write($"{mostFrequentElement} ");
            }
        }
    }
}
