using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestWordFrequencyAnalyzer
    {
        [TestMethod]
        public void TestCalculateHighestFrequency()
        {
            var Testing = new WordFrequencyAnalyzer();

            int Number = Testing.CalculateHighestFrequency("The suN2 'shi1nes OVER the lake1");

            Console.WriteLine(Number);

        }
    }
}
