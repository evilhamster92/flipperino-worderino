using FlipperinoWorderino.Contracts.Models;
using System;

namespace FlipperinoWorderino.Services
{
    public class WordService
    {
        public string InternalArrayReverse(WordRequest wordToReverse)
        {
            char[] charArray = wordToReverse.InitialWord.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string IterateReverse(WordRequest wordToReverse)
        {
            string str = wordToReverse.InitialWord.ToString(), reverse = "";
            int Length = 0;

            Length = str.Length - 1;
            while (Length >= 0)
            {
                reverse = reverse + str[Length];
                Length--;
            }

            return reverse;
        }
    }
}
