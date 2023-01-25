using System;
using System.Collections.Generic;

namespace ExistingPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            bool givingNumbers = true;
            int number;

            Console.WriteLine("Give numbers: ");

            while (givingNumbers)
            {
                bool success = int.TryParse(Console.ReadLine(), out number);
                if (success)
                {
                    numbers.Add(number);
                } else
                {
                    givingNumbers = false;
                }
            }

            int result = 0;

            foreach (int n in numbers)
            {
                result |= n;
            };

            string resultString = "";

            for (int i = 0; i < 32; i++)
            {
                int power = 1 << i;
                if ((result & power) != 0)
                {
                    resultString += power.ToString() + ", ";
                }
            }
            Console.WriteLine($"{resultString.Remove(resultString.Length - 2)}");
            Console.ReadKey();
        }
    }
}
