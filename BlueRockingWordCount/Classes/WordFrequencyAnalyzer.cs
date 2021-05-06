using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlueRockingWordCount.Classes
{
    public class WordFrequencyAnalyzer : BlueRockingWordCount.Interfaces.IWordFrequencyAnalyzer
    {
        public int CalculateFrequencyForWord(string text, string word)
        {
            throw new NotImplementedException();
        }

        public int CalculateHighestFrequency(string text)
        {
            throw new NotImplementedException();
        }

        public IList<BlueRockingWordCount.IWordFrequency> CalculateMostFrequentWords(string text, int number)
        {
            throw new NotImplementedException();
        }
    }
}
