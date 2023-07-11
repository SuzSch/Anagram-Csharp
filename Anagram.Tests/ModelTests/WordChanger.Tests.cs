using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;
using System;

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
    }
}