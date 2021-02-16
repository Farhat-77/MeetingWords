using System;
using System.Collections.Generic;
using System.Linq;

namespace MeetingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "Behold";
            string text2 = "House";
            string text3 = "which the";
            string text4 = "built by";
            string text5 = "Jack";
            string text6 = "and";
            string text7 = "this";
            string text8 = "wheat";
            string text9 = "Which";
            string text10 = "in";
            string text11 = "dark";
            string text12 = "closet";
            string text13 = "in";
            string text14 = "In";
            string text15 = "home";
            string text16 = "funny";
            string text17 = "tit-bird";
            string text18 = "often";
            string text19 = "steals";
            string text20 = "wheat";
            string text = text1 + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text10 
                + text11 + text12 + text13 + text14 + text15 + text16 + text17 + text18 + text19 + text20;
            Console.WriteLine(text);

            var counter = CountWords(text);
            var sortedByWord = counter.OrderBy(x => x.Key);
            var sortedByFrequency = sortedByWord.OrderBy(x => x.Value);
            foreach (KeyValuePair<string, int> kvp in sortedByFrequency)
                Console.WriteLine("   {0, 16} {1, 3}", kvp.Key, kvp.Value);
            Console.ReadKey();
        }
        public static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> counter = new Dictionary<string, int>();
            if (String.IsNullOrWhiteSpace(text))
            {
                Console.WriteLine("\nThere is no word in the given text.");
                return counter;
            }
            string[] wordArray = text.Split(new Char[] { ' ', ',', '.', ':', '-', '(', ')', '“', '”', '\t', '\n' });
            foreach (string word in wordArray)
            {
                if (word.Trim() != "")
                {
                    try
                    {
                        if (counter.ContainsKey(word) == false)
                            counter.Add(word, 1);
                        else
                            counter[word]++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("{0}", e.Message);
                    }
                }
            }
            return counter;
        }
    }
}
