using System.Collections.Generic;
using System;


namespace Anagram.Models
{
    public class WordChanger
    {
        public static Dictionary<string, char[]> mainWordDictionary = new Dictionary<string, char[]>() { };
        public static Dictionary<string, char[]> listDictionary = new Dictionary<string, char[]>() { };
        public static char[] ChangeWordToArray(string userInput)
        {
            string newWord = userInput.ToLower();
            char[] wordArray = newWord.ToCharArray();
            Array.Sort(wordArray);
            return wordArray;
        }

        public static void StoreMainWord(string mainword)
        {
            char[] wordArray = WordChanger.ChangeWordToArray(mainword);
            mainWordDictionary.Add(mainword, wordArray);
        }

        public static void StoreListWords(string listword)
        {
            char[] wordArray = WordChanger.ChangeWordToArray(listword);
            listDictionary.Add(listword, wordArray);
        }

    }
}