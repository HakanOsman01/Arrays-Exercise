using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            for(int currentPeople = 0; currentPeople < n; currentPeople++)
            {
                int people = int.Parse(Console.ReadLine());
                wagons[currentPeople] = people;
            }
            int sumOfPeolpe = wagons.Sum();
            foreach(int people in wagons)
            {
                Console.Write($"{people} ");
            }
            Console.WriteLine();
            Console.WriteLine(sumOfPeolpe);
        }
    }
}
