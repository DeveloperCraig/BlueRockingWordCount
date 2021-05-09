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
        ///<summary>
        ///This test will check to make sure it returns a list type
        /// </summary>
        public void TestDoesReturnIListType()
        {
            var Testing = new WordFrequencyAnalyzer();
            Assert.IsInstanceOfType(Testing.CalculateMostFrequentWords("The Man jumped over the moon while the man looked up at the sky", 2), typeof(IList<BlueRockingWordCount.Interfaces.IWordFrequency>));
        }

        [TestMethod]
        [TestCategory("CalculateMostFrequentWords")]
        ///<summary>
        ///This Test will run though the code just like if the user would.
        /// </summary>
        public void TestCompleateMethod()
        {
            var Testing = new WordFrequencyAnalyzer();
            var wordFrequencies = Testing.CalculateMostFrequentWords("The Man jumped over the moon while the man looked up at the sky", 2);

            foreach (var item in wordFrequencies)
            {
                Console.WriteLine(item.Word + " " + item.Frequency);
            }

        }
    }
}
