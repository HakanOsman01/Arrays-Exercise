using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().
               Split()
              .Select(int.Parse)
              .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length == 1)
                {
                    Console.WriteLine(0);
                    return;
                }
                int leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextElementPosition = sumLeft - 1;
                    if (sumLeft > 0)
                    {
                        leftSum += numbers[nextElementPosition];
                    }
                }
                int rightSum = 0;
                for (int sumRight = i; sumRight < numbers.Length; sumRight++)
                {
                    int nextElementPosion = sumRight + 1;
                    if (sumRight < numbers.Length - 1)
                    {
                        rightSum += numbers[nextElementPosion];
                    }
                }
                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }
           
            Console.WriteLine("no");
        }
        
    }
}
