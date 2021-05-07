using BlueRockingWordCount.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlueRockingWordCount.Classes
{
    public class WordFrequencyAnalyzer : BlueRockingWordCount.Interfaces.IWordFrequencyAnalyzer
    {
        //NOTE: This is technicly working but could be better
        public int CalculateHighestFrequency(string text)
        {
            //NOTE: This will just come back with the most request word and how often its used.
            string words = text;
            try
            {
                if (Regex.IsMatch(words, @"[&\/\\#,+()$~%.'"":*?<>{}0-9]"))
                {
                    throw new Exception("You cannot have speical charaters or Numbers in the word");
                }
                else
                {
                    words.ToLower();
                    string[] wordsArry = words.Split(' ');

                    wordsArry.Count();

                    var largestNumber = wordsArry
                                        .GroupBy(l => l)
                                        .OrderByDescending(g => g.Count());


                    //NOTE: This isnt needed in this bit of code
                    foreach (var item in largestNumber)
                    {
                        Console.WriteLine("{0}, {1}", item.Count(), item.Key);
                    }

                    return largestNumber.FirstOrDefault().Count();

                    //ISSUE: If the wordring doesn't have any duplicates then it will just come back with the first word

                }


            }
            catch (Exception e)
            {

                throw e;
            }

        }

        public int CalculateFrequencyForWord(string text, string word)
        {
            //NOTE: This one you have a long bit of text and the word the user is trying to find.


            throw new NotImplementedException();
        }
        public IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            //NOTE: This basicly will retern a list of words with the number of times it appeares, however it will only show
            // a set number of words based on the "number" interger

            throw new NotImplementedException();
        }
    }
}
