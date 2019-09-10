using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquareExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdm = new Random();
            var randomNumbers = new List<int>();
            for (var i = 0; i < 20; i++)
            {
                int randNumToAdd = rdm.Next(50);
                randomNumbers.Add(randNumToAdd);
            }
            var squaredNumbers = randomNumbers.Select(num => (num * num));
            var evenSquaredNumbers = squaredNumbers.Where(num => num % 2 == 0);


            Console.WriteLine("This is the original random number list");
            foreach (var num in randomNumbers)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine();
            Console.WriteLine("This is the squared list");
            foreach (var squaredNum in squaredNumbers)
            {
                Console.Write($"{squaredNum} ");
            }
            Console.WriteLine();
            Console.WriteLine("This is just the evens!");
            foreach (var evenSquaredNum in evenSquaredNumbers)
            {
                Console.Write($"{evenSquaredNum} ");
            }

        }
    }
}
