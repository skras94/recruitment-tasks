using System;
using System.Linq;
using System.Text;

namespace CommonDigit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());

            if (n > 20 || n < 2)
            {
                Console.WriteLine("Incorrect n value...");
                return;
            }

            char sign;
            StringBuilder sb = new StringBuilder();
            int[] array = new int[n];

            for (int i = 0; i < n;)
            {
                sign = Console.ReadKey().KeyChar;

                if (sign == ' ')
                {
                    array[i] = int.Parse(sb.ToString());
                    sb.Clear();
                    i++;
                }
                else if (char.IsNumber(sign))
                {
                    sb.Append(sign);
                }
            }

            int[] countArray = new int[10];

            foreach (int number in array)
            {
                for (int d = 0; d < 10; d++)
                {
                    countArray[d] += CountDigit(number, d);
                }
            }

            int mostOccurringNumber = countArray
                .Select((k, i) => new { k, i })
                .GroupBy(x => x.k, x => x.i)
                .OrderByDescending(x => x.Key)
                .Take(1)
                .SelectMany(x => x)
                .ToArray().Max();

            Console.WriteLine($"\nMost occurring digit is: {mostOccurringNumber}");

            Console.ReadKey();
        }

        private static int CountDigit(int number, int divider)
        {
            int count = 0;

            while (number > 0)
            {
                if (number % 10 == divider)
                {
                    count++;
                }
                number = number / 10;
            }

            return count;
        }
    }
}
