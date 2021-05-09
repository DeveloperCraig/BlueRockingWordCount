using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestWordFrequencyAnalyzer
    {
        [TestMethod]
        [TestCategory("BasicTestArea")]
        public void TestCalculateHighestFrequency()
        {
            var Testing = new WordFrequencyAnalyzer();

            int Number = Testing.CalculateHighestFrequency("The suN2 'shi1nes OVER the lake1");

            Console.WriteLine(Number);

        }


        [TestMethod]
        [TestCategory("BasicTestArea")]
        public void TestCalculateMostFrequentWords()
        {
            var Testing = new WordFrequencyAnalyzer();
            var wordFrequencies = Testing.CalculateMostFrequentWords("The Man jumped over the moon while the man looked up at the sky", 2);

            foreach (var item in wordFrequencies)
            {
                Console.WriteLine(item.Word + " " + item.Frequency);
            }

        }


        [TestMethod]
        [TestCategory("BasicTestArea")]
        public void TestCalculateFrequencyForWord()
        {
            var Testing = new WordFrequencyAnalyzer();
            Testing.CalculateFrequencyForWord("The Man jumped over the moon while the man looked up at the sky", "Man");

        }
    }
}
