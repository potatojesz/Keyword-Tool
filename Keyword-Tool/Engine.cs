using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Keyword_Tool
{
    public static class Engine
    {
        public static string GenerateKeywordsString(ICollection<string> input)
        {
            StringBuilder resultStr = new StringBuilder();
            HashSet<string> result = GenerateKeywords(input);
            foreach (string str in result)
            {
                resultStr.Append(str).Append(System.Environment.NewLine);
            }
            return resultStr.ToString().Trim();
        }

        public static HashSet<string> GenerateKeywords(ICollection<string> input)
        {
            HashSet<string> result = new HashSet<string>();
            foreach (string str in input)
            {
                string[] splited = str.Split(null);

                //Add same words with plus sign
                result.Add(GeneratePlusSignReapetedPhrase(splited));

                //Add all unique combinations in [ *** ]
                List<string> combinations = GenerateCombinations(splited);
                foreach (string combination in combinations)
                {
                    result.Add(combination);
                }
            }

            return result;
        }

        private static List<string> GenerateCombinations(string[] input)
        {
            List<string> result = new List<string>();
            Permute(input, 0, input.Length - 1, result);
            return result;
        }

        private static void Permute(string[] input,
                               int startIndex, int endIndex, List<string> result)
        {
            if (startIndex == endIndex) {
                string res = "[";
                foreach (string str in input)
                    res += str + " ";
                result.Add(res.Trim() + "]");
            }
            else
            {
                for (int i = startIndex; i <= endIndex; i++)
                {
                    input = Swap(input, startIndex, i);
                    Permute(input, startIndex + 1, endIndex, result);
                    input = Swap(input, startIndex, i);
                }
            }
        }

        private static string[] Swap(string[] str,
                                  int startIndex, int endIndex)
        {
            string temp;
            temp = str[startIndex];
            str[startIndex] = str[endIndex];
            str[endIndex] = temp;

            List<string> result = new List<string>();
            foreach (string add in str)
            {
                result.Add(add);
            }

            return result.ToArray();
        } 
  
        private static string GeneratePlusSignReapetedPhrase(string[] splited)
        {
            StringBuilder result = new StringBuilder();

            foreach (string str in splited)
            {
                result.Append(" +" + str.Trim());
            }

            return result.ToString().Trim();
        }
    }
}
