using System;
using System.Collections.Generic;

namespace random_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            List<int> numbers = new List<int> {
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
                random.Next(6),
            };

            for (int i = 0; i < numbers.Count; i++)
            {
                // Determine if the current loop index is contained inside of the `numbers` list. Print a message to the console indicating whether the index is in the list.
                if(i == numbers[i]) {
                    Console.WriteLine($"numbers List contains {i}");
                } else {
                    Console.WriteLine($"numbers list does not contain {i}");
                }

            }
        }
    }
}
