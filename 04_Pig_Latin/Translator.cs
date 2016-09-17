using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace _04_Pig_Latin
{
    internal class Translator
    {
        private string[] vowel = new string[] { "a", "e", "i", "o", "y" };

        internal string Translate(string input)
        {
            string[] inputArray = input.Split(' ');
            StringBuilder sbInput = new StringBuilder();

            foreach (string word in inputArray)
            {
                if (isVowel(word))
                    sbInput.Append(VowelWord(word)).Append(" ");
                else
                    sbInput.Append(ConsWord(word)).Append(" ");
            }

            sbInput.AppendLine();

            return sbInput.ToString().Trim();
        }


        private Boolean isVowel(String input)
        {
            if (vowel.Contains(input.Substring(0, 1).ToLower()))
                return true;
            else return false;
        }

        private String VowelWord(String word)
        {
            return word + "ay";
        }

        private string ConsWord(string word)
        {
            bool isConst = true;

            while (isConst)
            {
                if (!isVowel(word))
                {
                    word = word.Substring(1, word.Length - 1) + word.Substring(0, 1);
                }
                else
                {
                    isConst = false;
                }
            }
            word = word + "ay";
            return word;
        }
    }
}