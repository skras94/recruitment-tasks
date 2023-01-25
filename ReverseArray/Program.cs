using System;

namespace ReverseArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Set n: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Set array (separated by space): ");
            int[] array = new int[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadKey().KeyChar.ToString());
                Console.Write(" ");
            }

            Array.Reverse(array);
            Console.WriteLine();

            foreach (int element in array)
            {
                Console.Write(element + " ");
            }

            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
