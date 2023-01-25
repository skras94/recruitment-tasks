using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingPrimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give T: ");
            int T = int.Parse(Console.ReadLine());

            int[][] arrays = new int[T][];
            StringBuilder sb = new StringBuilder();
            char sign;

            Console.WriteLine("Give numbers: ");

            for (int i = 0; i < T; i++)
            {
                arrays[i] = new int[2];

                for (int j = 0; j < arrays[i].Length;)
                {
                    sign = Console.ReadKey().KeyChar;

                    if (sign == ' ')
                    {
                        arrays[i][j] = int.Parse(sb.ToString());
                        sb.Clear();
                        j++;
                    }
                    else if (char.IsNumber(sign))
                    {
                        sb.Append(sign);
                    }
                }

                Console.WriteLine();
            }

            foreach (int[] elements in arrays)
            {
                Console.WriteLine(CountPrimes(elements[0], elements[1]));
            }

            Console.ReadKey();
        }

        private static int CountPrimes(int number1, int number2)
        {
            int sum = 0;
            bool isPrime;

            for (int i = number1 + 1; i < number2; i++)
            {
                isPrime = true;
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
