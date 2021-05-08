using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestCalculateHighestFrequency
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "You cannot have speical charaters or Numbers in the word")]
        public void TestSpecialCharacters()
        {
            //TODO: Add a test to make sure special characters come back with an error.
            var Test = new WordFrequencyAnalyzer();
            Test.CalculateHighestFrequency("This Should Fa'l");


        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException),
        "You cannot have speical charaters or Numbers in the word")]
        public void TestNumberCharacters()
        {
            //TODO: Add a test to make sure Numbers characters come back with an error.
            var Test = new WordFrequencyAnalyzer();
            Test.CalculateHighestFrequency("This Should Fa1l");
        }
        [TestMethod]
        [DataRow("Wisdom is easily acquired when hiding under the bed with a saucepan on your head")]
        public void TestCalculateHighestFrequency(string testText)
        {
            //TODO: This will just test to make sure its working correctly.
            var Test = new WordFrequencyAnalyzer();
            int TestNumber = Test.CalculateHighestFrequency(testText);
            Assert.IsNotNull(TestNumber);
        }
    }
}
