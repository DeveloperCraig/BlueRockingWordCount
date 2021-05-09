using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestCalculateMostFrequentWords
    {
        [TestMethod]
        [TestCategory("CalculateMostFrequentWords")]
        [DataRow("The Man jumped over the moon while the man looked up at the sky", 2)]
        ///<summary>
        ///This test will check to make sure it returns a list type
        /// </summary>
        public void TestDoesReturnIListType(string text, int number)
        {
            var Testing = new WordFrequencyAnalyzer();
            Assert.IsInstanceOfType(Testing.CalculateMostFrequentWords(text, number), typeof(IList<BlueRockingWordCount.Interfaces.IWordFrequency>));
        }

        [TestMethod]
        [TestCategory("CalculateMostFrequentWords")]
        [DataRow("The Man jumped over the moon while the man looked up at the sky", 2)]
        ///<summary>
        ///This Test will run though the code just like if the user would.
        /// </summary>
        public void TestCompleateMethod(string text, int number)
        {
            var Testing = new WordFrequencyAnalyzer();
            var wordFrequencies = Testing.CalculateMostFrequentWords(text, number);

            foreach (var item in wordFrequencies)
            {
                Console.WriteLine(item.Word + " " + item.Frequency);
            }
            Assert.IsNotNull(wordFrequencies);
        }


        [TestMethod]
        [TestCategory("CalculateMostFrequentWords")]
        [DataRow("Bacon Apple Cheese donut egg", 2)]
        public void TestDoesCodeSortByAlphabetical(string text, int number)
        {
            var Testing = new WordFrequencyAnalyzer();
            foreach (var item in Testing.CalculateMostFrequentWords(text, number))
            {
                Console.WriteLine(item.Word);
            }
        }
    }
}
