using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestBasicTestArea
    {
        [TestMethod]
        [TestCategory("BasicTestArea")]
        [DataRow("Wisdom is easily acquired when hiding under the bed with a saucepan on your head")]
        public void TestCalculateHighestFrequency(string text)
        {
            var Test = new WordFrequencyAnalyzer();
            int TestNumber = Test.CalculateHighestFrequency(text);
            Assert.IsNotNull(TestNumber);

        }


        [TestMethod]
        [TestCategory("BasicTestArea")]
        [DataRow("The Man jumped over the moon while the man looked up at the sky", 2)]
        public void TestCalculateMostFrequentWords(string text, int number)
        {
            var Testing = new WordFrequencyAnalyzer();
            var wordFrequencies = Testing.CalculateMostFrequentWords(text, number);
            Assert.IsNotNull(wordFrequencies);

        }


        [TestMethod]
        [TestCategory("BasicTestArea")]
        [DataRow("Bacon Apple donut donut Cheese donut egg", "donut")]
        public void TestCalculateFrequencyForWord(string text, string word)
        {
            var Test = new WordFrequencyAnalyzer();
            int TestNumber = Test.CalculateFrequencyForWord(text, word);
            Assert.AreEqual(3, TestNumber);

        }
    }
}
