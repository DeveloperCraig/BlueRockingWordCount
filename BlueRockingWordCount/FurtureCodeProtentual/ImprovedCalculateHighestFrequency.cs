using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BlueRockingWordCount.FurtureCodeProtentual
{
    class ImprovedCalculateHighestFrequency
    {
        public int CalculateHighestFrequency(string text)
        {
            //NOTE: This will just come back with the most request word and how often its used.
            string words;
            try
            {

                //TODO: We need to first Remove any speical characters and numbers from the string (Futrue prof)
                words = Regex.Replace(text, @"[^ a-zA-Z]+", "").ToLower();


                string[] wordsArry = words.Split(' ');

                wordsArry.Count();

                var largestNumber = wordsArry
                                    .GroupBy(l => l)
                                    .OrderByDescending(g => g.Count());

                foreach (var item in largestNumber)
                {
                    Console.WriteLine("{0}, {1}", item.Count(), item.Key);
                }

                return largestNumber.FirstOrDefault().Count();

                //ISSUE: If the wordring doesn't have any duplicates then it will just come back with the first word

            }
            catch (Exception)
            {

                throw;
            }

            throw new NotImplementedException();

        }
    }
}
