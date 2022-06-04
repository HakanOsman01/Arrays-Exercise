using System;
using System.Linq;

namespace Kamino
{
    class Program
    {
        static void Main(string[] args)
        {
            int sequnceLenght = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] Dna = new int[sequnceLenght];
            int dnaSum = 0;
            int dnaCount = -1;
            int dnaSample = 0;
            int dnaStartIndex = -1;
            int sample = 0;
            while (input != "Clone them!")
            {
                sample++;
                int[] curDna = input.
                Split("!", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                int curCount = 0;
                int curDnaSum = 0;
                int curStartIndex = 0;
                int curEndIndex = 0;
                bool isDnaBetter = false;
                int count = 0;
                for (int i = 0; i < curDna.Length; i++)
                {
                    if (curDna[i] != 1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count > curCount)
                    {
                        curCount = count;
                        curEndIndex = i;
                    }
                }
                curStartIndex = curEndIndex - curCount + 1;
                curDnaSum = curDna.Sum();
                if (curCount > dnaCount)
                {
                    isDnaBetter = true;
                }
                else if (curCount == dnaCount)
                {
                    if (curStartIndex < dnaStartIndex)
                    {
                        isDnaBetter = true;
                    }
                    else if (curStartIndex == dnaStartIndex)
                    {
                        if (curDnaSum > dnaSum)
                        {
                            isDnaBetter = true;
                        }
                    }
                }
                if (isDnaBetter)
                {
                    dnaSample = sample;
                    Dna = curDna;
                    dnaStartIndex = curStartIndex;
                    dnaSum = curDnaSum;
                    dnaCount = curCount;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Best DNA sample {dnaSample} with sum: {dnaSum}.");
            Console.WriteLine(string.Join(" ", Dna));
        }
    }
}