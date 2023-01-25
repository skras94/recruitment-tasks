using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Permutation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 11;
            int[][] arrays = new int[2][];
            StringBuilder sb = new StringBuilder();
            char sign;

            Console.WriteLine("Give arrays: ");

            for (int i = 0; i < 2; i++)
            {
                arrays[i] = new int[length];
                for (int j = 0; j < length;)
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

            Console.WriteLine();
            if (IsPermutation(arrays[0], arrays[1]))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");

            Console.ReadKey();
        }

        private static bool IsPermutation(int[] array1, int[] array2)
        {
            Array.Sort(array1);
            Array.Sort(array2);

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] != array2[i])
                    return false;
            }

            return true;
        }
    }
}
