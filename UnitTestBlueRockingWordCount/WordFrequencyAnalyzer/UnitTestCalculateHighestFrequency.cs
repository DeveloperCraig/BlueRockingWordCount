using BlueRockingWordCount.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestCalculateHighestFrequency
    {
        [TestMethod]
        [TestCategory("CalculateHighestFrequency")]
        [ExpectedException(typeof(ArgumentException),
        "You cannot have special characters or Numbers in the word")]
        /// <summary>
        /// This Test will test to see if the code will throw an error if the user enters a special character
        /// </summary>
        public void TestSpecialCharacters()
        {
            //TODO: Add a test to make sure special characters come back with an error.
            var Test = new WordFrequencyAnalyzer();
            Test.CalculateHighestFrequency("This Should Fa'l");
        }


        [TestMethod]
        [TestCategory("CalculateHighestFrequency")]
        [ExpectedException(typeof(ArgumentException),
        "You cannot have special characters or Numbers in the word")]
        /// <summary>
        /// This Test will test to see if the code will throw an error if the user enters a number
        /// </summary>
        public void TestNumberCharacters()
        {
            var Test = new WordFrequencyAnalyzer();
            Test.CalculateHighestFrequency("This Should Fa1l");
        }


        [TestMethod]
        [TestCategory("CalculateHighestFrequency")]
        [DataRow("Wisdom is easily acquired when hiding under the bed with a saucepan on your head")]
        ///<summary>
        ///This Test should be the full test to make sure it runs though the code correctly and outcome with a number
        /// </summary>
        public void TestCalculateHighestFrequency(string text)
        {
            var Test = new WordFrequencyAnalyzer();
            int TestNumber = Test.CalculateHighestFrequency(text);
            Assert.IsNotNull(TestNumber);
        }
    }
}
