using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            int[] firstZigZagArray = new int[lines];
            int[] secondZigZagArray = new int[lines];
            for(int i = 0;i<lines; i++)
            {
                int curLine = i + 1;
                int[] values = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                if (curLine % 2 != 0)
                {
                    firstZigZagArray[i] = values[0];
                    secondZigZagArray[i] = values[1];
                }
                else
                {
                    firstZigZagArray[i] = values[1];
                    secondZigZagArray[i] = values[0];
                }

            }
            Console.WriteLine(string.Join(' ', firstZigZagArray));
            Console.WriteLine(string.Join(' ',secondZigZagArray));
        }
    }
}
