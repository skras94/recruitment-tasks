using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word, reversedWord = "";

            Console.Write("Give a word: ");
            word = Console.ReadLine();

            word = new Regex("[^a-zA-Z]").Replace(word, "");

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            if (word == reversedWord)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}
