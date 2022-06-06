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
            string command=Console.ReadLine();
            bool isLenghtUnderZero = false;
            while (command != "end")
            {
                string[] ladyBugsCommands = command
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                int index = int.Parse(ladyBugsCommands[0]);
                string direction = ladyBugsCommands[1];
                int lenght = int.Parse(ladyBugsCommands[2]);
                if(index<0 || index >= field.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (field[index]!= 1)
                {
                    command = Console.ReadLine();
                    continue;
                }
                if (lenght < 0)
                {
                    isLenghtUnderZero = true;
                    if (direction == "right")
                    {
                        direction = "left";
                    }
                    else
                    {
                        direction = "right";
                    }
                }

                field[index] = 0;
                while (true)
                {
                    if (direction == "right")
                    {
                        if (isLenghtUnderZero)
                        {
                            lenght *= -1;
                        }
                        index += lenght;
                        if (index >= field.Length)
                        {
                            break;
                        }
                            if (field[index] == 0)
                            {
                                field[index] = 1;
                               break;
                            }
                            else if (field[index] != 0)
                            {
                                continue;
                            }
                        
                    }
                    else if(direction=="left")
                    { 
                            index -= lenght;
                            if (index < 0)
                            {
                                break;
                            }
                            if (field[index] == 0)
                            {
                                field[index] = 1;
                                break;
                            }
                            else if (field[index] != 0)
                            {
                                continue;
                            }
                    }
                }
                
              command = Console.ReadLine();
            }
            string output = string.Join(' ', field);
            Console.WriteLine(output);
           
        }
    }
}

