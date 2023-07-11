using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;


namespace Anagram.Tests
{
    [TestClass]
    public class WordChangerTests
    {
        [TestMethod]
        public void ChangeWordToArray_ChangeToArray_Array()
        {
            string userInput = "gig";
            char[] Result = WordChanger.ChangeWordToArray(userInput);
            Assert.AreEqual(typeof(char[]), Result.GetType());
        }

        [TestMethod]
        public void ChangeWordToArray_SortArray_Array()
        {
            string userInput = "gig";
            char[] Result = WordChanger.ChangeWordToArray(userInput);
            char[] expectedResult = { 'g', 'g', 'i' };
            CollectionAssert.AreEqual(expectedResult, Result);
        }

        [TestMethod]
        public void StoreMainWord_StoreWord_Void()
        {
            string userInput = "cat";
            char[] catSorted = { 'a', 'c', 't' };
            WordChanger.StoreMainWord(userInput);
            Dictionary<string, char[]> Result = WordChanger.mainWordDictionary;
            Dictionary<string, char[]> expectedResult = new Dictionary<string, char[]>() { { "cat", catSorted }, };
            CollectionAssert.AreEqual(expectedResult["cat"], Result[userInput]);
            // CollectionAssert.AreEqual(expectedResult.Values, Result.Values);
        }


    }
}