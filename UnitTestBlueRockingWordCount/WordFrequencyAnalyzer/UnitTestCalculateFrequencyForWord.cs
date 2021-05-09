using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestCalculateFrequencyForWord
    {
        [TestMethod]
        [TestCategory("CalculateFrequencyForWord")]
        [DataRow("Bacon Apple donut donut Cheese donut egg", "donut")]
        ///<summary>
        ///This is to check that it will come back with 3
        /// </summary>
        public void TestMethodCompleateTest(string text, string word)
        {
            var Test = new WordFrequencyAnalyzer();
            int TestNumber = Test.CalculateFrequencyForWord(text, word);
            Assert.AreEqual(3, TestNumber);
        }

        [TestMethod]
        [TestCategory("CalculateFrequencyForWord")]
        [ExpectedException(typeof(ArgumentException),
        "You cannot have special characters or Numbers in the word")]
        [DataRow("This Should Fa'l", "this")]
        /// <summary>
        /// This Test will test to see if the code will throw an error if the user enters a special character
        /// </summary>
        public void TestSpecialCharacters(string text, string word)
        {
            //TODO: Add a test to make sure special characters come back with an error.
            var Test = new WordFrequencyAnalyzer();
            Test.CalculateFrequencyForWord(text, word);
        }
    }
}
