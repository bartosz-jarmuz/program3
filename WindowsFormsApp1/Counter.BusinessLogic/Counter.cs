using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace Counter.BusinessLogic
{

    public class CounterDelay
    {

        private int delayTime;
        private int countTill;

        public CounterDelay(int delay, int count)
        {
            delayTime = delay;
            countTill = count;
        }

        public void Count(Action<int> whenWaitingIsFinished)
        {
            for (int i = 0; i < countTill; i++)
            {
                Thread.Sleep(delayTime);
                whenWaitingIsFinished(i);
            }
        }
    }

    public class ConvertToNumeric
    {
        private int delayTime;
        private int countTill;

        public ConvertToNumeric(string delayTimeString, string countTillString)
        {
            delayTime = ParseEnglish(delayTimeString);
            countTill = ParseEnglish(countTillString);
        }

        public int ReturnNumericDelayTime(string delaytimeString)
        {
            return Convert.ToInt32(ParseEnglish(delaytimeString));
        }
        public int ReturnNumericcountTill(string countTillString)
        {
            return Convert.ToInt32(ParseEnglish(countTillString));
        }

        public int ParseEnglish(string number)
        {
            string[] words = number.ToLower().Split(new char[] { ' ', '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            string[] ones = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] teens = { "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] tens = { "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            Dictionary<string, int> modifiers = new Dictionary<string, int>()
            {   {"billion", 1000000000},
                {"million", 1000000},
                {"thousand", 1000},
                {"hundred", 100}
            };

            if (number == "eleventy billion")
                return int.MaxValue; // 110,000,000,000 is out of range for an int!

            int result = 0;
            int currentResult = 0;
            int lastModifier = 1;

            foreach (string word in words)
            {
                if (modifiers.ContainsKey(word))
                {
                    lastModifier *= modifiers[word];
                }
                else
                {
                    int n;

                    if (lastModifier > 1)
                    {
                        result += currentResult * lastModifier;
                        lastModifier = 1;
                        currentResult = 0;
                    }

                    if ((n = Array.IndexOf(ones, word) + 1) > 0)
                    {
                        currentResult += n;
                    }
                    else if ((n = Array.IndexOf(teens, word) + 1) > 0)
                    {
                        currentResult += n + 10;
                    }
                    else if ((n = Array.IndexOf(tens, word) + 1) > 0)
                    {
                        currentResult += n * 10;
                    }
                    else if (word != "and")
                    {
                        throw new ApplicationException("Unrecognized word: " + word);
                    }
                }
            }

            return result + currentResult * lastModifier;
        }

    }

    
}
