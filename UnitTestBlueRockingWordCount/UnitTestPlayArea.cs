using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Text.RegularExpressions;

namespace UnitTestBlueRockingWordCount
{
    [TestClass]
    public class UnitTestPlayArea
    {
        [TestMethod]
        [DataRow("The suN2 'shi1nes OVER the lake1")]
        public void TestRegex(string text)
        {
            try
            {
                //NOTE: This will remove All numbers and special characters
                //Regex.Replace(text, @"[^ a-zA-Z]+", "");



                Console.WriteLine(Regex.Replace(text, @"[^ a-zA-Z]+", "").ToLower());
            }
            catch (Exception e)
            {

                Console.WriteLine(e.StackTrace);
            }




        }
    }
}
