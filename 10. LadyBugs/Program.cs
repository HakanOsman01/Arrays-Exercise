using System;
using System.Linq;

namespace _10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugsIndex = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int index = 0; index < fieldSize; index++)
            {
                if (ladyBugsIndex.Contains(index))
                {
                    field[index] = 1;
                }
            }
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.
                Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
                int initinalIndex = int.Parse(cmdArgs[0]);
                string direction = cmdArgs[1];
                int flyLenght = int.Parse(cmdArgs[2]);
                if (initinalIndex < 0 || initinalIndex >= field.Length)
                {
                    continue;
                }
                if (field[initinalIndex] == 0)
                {
                    continue;
                }
                field[initinalIndex] = 0;
                int nextIndex = initinalIndex;
                while (true)
                {
                    if (direction == "right")
                    {
                        nextIndex += flyLenght;
                    }
                    else if (direction == "left")
                    {
                        nextIndex -= flyLenght;
                    }
                    if (nextIndex < 0 || nextIndex >= field.Length)
                    {
                        break;
                    }
                    if (field[initinalIndex] == 0)
                    {
                        break;
                    }

                }

                if (nextIndex >= 0 && nextIndex < field.Length)
                {
                    field[nextIndex] = 1;
                }
            }
            Console.WriteLine(string.Join(' ', field));
        }
    }
}
