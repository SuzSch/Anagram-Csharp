using System;
using System.Collections.Generic;
using Anagram.Models;
using System.Linq;

namespace Anagram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*");
            Console.WriteLine("Hello. Type in a word:");
            string mainword = Console.ReadLine();
            WordChanger.StoreMainWord(mainword);
            Console.WriteLine("Now, enter in 3 words that you think is an anagram and our program will check it");
            Console.WriteLine("Enter a word:");
            string word1 = Console.ReadLine();
            WordChanger.StoreListWords(word1);
            Console.WriteLine("Enter a word:");
            string word2 = Console.ReadLine();
            WordChanger.StoreListWords(word2);
            Console.WriteLine("Enter a word:");
            string word3 = Console.ReadLine();
            WordChanger.StoreListWords(word3);
            Console.WriteLine($"These are the words that were an anagram for {mainword}");
            // List<string> keys = new List<string> { };
            foreach (KeyValuePair<string, char[]> word in WordChanger.listDictionary)
            {
                char[] listArray = word.Value;
                char[] mainArray = WordChanger.mainWordDictionary[mainword];
                if (listArray.SequenceEqual(mainArray) == true)
                {
                    Console.WriteLine($"{word.Key} IS AN ANAGRAM!");
                }
                else
                {
                    Console.WriteLine($"{word.Key} is not an anagram for {mainword}!");
                }
            }







            // foreach (string word in keys)
            // {
            //     Console.WriteLine(word);

            // }
            // Console.WriteLine("Did it work?");
        }
    }
}