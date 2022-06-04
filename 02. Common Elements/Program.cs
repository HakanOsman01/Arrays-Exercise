using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();
            string[] secondArray = Console.ReadLine()
                  .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();
            for(int i = 0; i < secondArray.Length; i++)
            {
                string secondElement = secondArray[i];
                for(int j = 0; j < firstArray.Length; j++)
                {
                    string firstElement = firstArray[j];
                    if (secondElement == firstElement)
                    {
                        Console.Write($"{secondElement} ");
                    }
                }
            }

        }
    }
}
