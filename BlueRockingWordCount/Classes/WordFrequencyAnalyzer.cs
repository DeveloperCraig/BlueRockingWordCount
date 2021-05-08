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
            
            //NOTE: This will make the text lower to help with comparing words
            string words = text.ToLower();
            try
            {
                //NOTE: This will find out if there is any invalid characters in the text
                if (Regex.IsMatch(words, @"[&\/\\#,+()$~%.'"":*?<>{}0-9]"))
                {
                    throw new ArgumentException("You cannot have speical charaters or Numbers in the word");
                }
                else
                {
                    //wordsArry.Count();
                    string[] wordsArry = words.Split(' ');


                    var largestNumber = wordsArry
                                        .GroupBy(l => l)
                                        .OrderByDescending(g => g.Count());

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
            List<IWordFrequency> List = new List<IWordFrequency>();
            string words = text.ToLower();
            int iteration = 0;
            try
            {
                string[] wordsArry = words.Split(' ');


                var largestNumber = wordsArry
                                    .GroupBy(l => l)
                                    .OrderByDescending(g => g.Count());

                
                {
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
                }




                //TODO: I need to return only a set number


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
