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
        //NOTE: This is technically working but could be better

        /// <summary>
        /// This will just come back with the most request word and how often its used.
        /// </summary>
        /// <param name="text"></param>
        /// <returns>A number of the most reoccurring word</returns>
        public int CalculateHighestFrequency(string text)
        {
            try
            {
                //NOTE: This will find out if there is any invalid characters in the text
                if (Regex.IsMatch(text, @"[&\/\\#,+()$~%.'"":*?<>{}0-9]"))
                {
                    throw new ArgumentException("You cannot have special characters or Numbers in the word");
                }
                else
                {
                    string[] wordsArry = text.ToLower().Split(' ');


                    var largestNumber = wordsArry
                                        .GroupBy(l => l)
                                        .OrderByDescending(g => g.Count());

                    return largestNumber.FirstOrDefault().Count();

                    //ISSUE: If the wording doesn't have any duplicates then it will just come back with the first word
                    //However the spec didn't mention it wanted anything to happen if there was no duplicates
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw e;
            }

        }


        /// <summary>
        /// This will allow you to search for a particular word and find out how many times its use within text
        /// </summary>
        /// <param name="text"></param>
        /// <param name="word"></param>
        /// <returns>A number relating to the number of times this word was used in the text</returns>
        public int CalculateFrequencyForWord(string text, string word)
        {
            try
            {
                if (Regex.IsMatch(text, @"[&\/\\#,+()$~%.'"":*?<>{}0-9]"))
                {
                    throw new ArgumentException("You cannot have special characters or Numbers in the word");
                }

                string[] texts = text.ToLower().Split(' ');

                var result = texts
                    .GroupBy(w => w)
                    .Where(w => w.Key == word.ToLower())
                    .Select(w => w.Count());


                return result.FirstOrDefault();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }


        /// <summary>
        /// This basically will return a list of words with the number of times it appearers, however it will only show a set number of words based on the "number" integer
        /// </summary>
        /// <param name="text"></param>
        /// <param name="number"></param>
        /// <returns>A list of words with the number of times it appearers</returns>
        public IList<IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {        
            try
            {
                List<IWordFrequency> List = new List<IWordFrequency>();
                int iteration = 0;
                IEnumerable<IGrouping<string, string>> largestNumber;

                //NOTE: This will find out if there is any invalid characters in the text
                if (Regex.IsMatch(text, @"[&\/\\#,+()$~%.'"":*?<>{}0-9]"))
                {
                    throw new ArgumentException("You cannot have special characters or Numbers in the word");
                }
                string[] wordsArry = text.ToLower().Split(' ');

                if (wordsArry.GroupBy(x => x).Any(g => g.Count() > 1))
                {
                    largestNumber = wordsArry
                    .GroupBy(l => l)
                    .OrderByDescending(g => g.Count());
                }
                else
                {
                    largestNumber = wordsArry
                        .GroupBy(l => l)
                        .OrderBy(g => g.Key);
                }


                foreach (var item in largestNumber)
                {
                    if (iteration < number)
                    {
                        List.Add(new WordFrequency { Word = item.Key, Frequency = item.Count() });
                        iteration++;
                    }
                    else
                    {
                        break;
                    }

                }

                return List;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                throw;
            }
        }
    }
}
