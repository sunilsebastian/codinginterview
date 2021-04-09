using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmazonVirtual
{


    public class LetterCombinationOfPhoneNumber
    {
        Dictionary<char, string> phone = new Dictionary<char, string>() {
        {'2', "abc"},
        {'3', "def"},
        {'4', "ghi"},
        {'5', "jkl"},
        { '6', "mno" },
        { '7', "pqrs" },
        { '8', "tuv" },
        { '9', "wxyz" }};


        public IList<string> LetterCombinations(string digits)
        {

            List<string> result = new List<string>();
            if (digits.Length != 0)
                LetterWordHelper(digits, result, 0, "");
            return result;

        }


        //Method 1
        private void LetterWordHelper(string digits, List<string> result, int trackingIndex, string newWord)
        {
            if (trackingIndex == digits.Length)
            {
                result.Add(newWord);
                return;
            }

            var letters = phone[digits[trackingIndex]];

            for (int i = 0; i < letters.Length; i++)
            {
                char letter = letters[i];

                LetterWordHelper(digits, result, trackingIndex + 1, newWord + letter);

            }

        }

        //Method 2
        private void LetterWordHelper1(string digits, List<string> result, string newWord)
        {

            if(string.IsNullOrWhiteSpace(digits))
            {
                result.Add(newWord);
                return;
            }

            char digit = digits[0];
            var letters = phone[digit];
            for(int i=0;i<letters.Length;i++)
            {
                char letter = letters[i];

                LetterWordHelper1(digits.Substring(1), result, newWord + letter);

            }


        }



            //------------------

            //Input : BABY { A, B } {B, A} {B, X} (Y, C}
            //Output: True

            //complexity Math.Pow(2,N)  2 is the items in list and N is the Length of input word
            public static bool CheckWordCanBeMade(List<List<char>> letters, string word)
        {
            return LetterWordHelper(letters, word, 0, "");
        }

        private static bool LetterWordHelper(List<List<char>> letters, string word, int trackingIndex, string newWord)
        {
            if(trackingIndex== letters.Count)
            {
                if (string.Equals(word, newWord))
                    return true;
                return false;
            }


           var items= letters[trackingIndex];

            for(int i= 0;i< items.Count;i++)
            {
                char letter = items[i];

              var result=  LetterWordHelper(letters, word, trackingIndex + 1, newWord + letter);
                if (result)
                    return true;
            }

            return false;

        }

        //---------------------------------------
    }


   
}
