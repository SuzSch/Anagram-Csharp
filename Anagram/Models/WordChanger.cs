using System.Collections.Generic;
using System;

namespace Anagram.Models
{
    public class WordChanger
    {
        public static char[] ChangeWordToArray(string userInput)
        {
            string newWord = userInput.ToLower();
            char[] wordArray = newWord.ToCharArray();
            return wordArray;
        }
    }
}