using System;
using System.Collections.Generic;

namespace Kastelo.Utils
{
    class CharacterManager
    {
        bool bAlpha = false;
        bool bNumeric = false;
        bool bPunctuation = false;
        bool bBrackets = false;
        bool bSpecials1 = false;
        bool bSpecials2 = false;

        public string strAlpha = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public string strNumeric = "1234567890";
        public string strPunctuation = @",.!";
        public string strBrackets = @"[]{}()<>";
        public string strSpecials1 = @"!£$%^&*_+#@~\/";
        public string strSpecials2 = @"`|";
        
        public void AlphaNumeric(bool use)
        {
            bAlpha = bNumeric = use;
        }
        public void Punctuation(bool use)
        {
            bPunctuation = use;
        }
        public void Brackets(bool use)
        {
            bBrackets = use;
        }
        public void Specials1(bool use)
        {
            bSpecials1 = use;
        }
        public void Specials2(bool use)
        {
            bSpecials2 = use;
        }

        public List<char> GenerateAllowableChars(string AdditionalChars = "")
        {
            var AllowableChars = new List<char>();
            if (bAlpha) AllowableChars.AddRange(strAlpha.ToCharArray());
            if (bNumeric) AllowableChars.AddRange(strNumeric.ToCharArray());
            if (bPunctuation) AllowableChars.AddRange(strPunctuation.ToCharArray());
            if (bBrackets) AllowableChars.AddRange(strBrackets.ToCharArray());
            if (bSpecials1) AllowableChars.AddRange(strSpecials1.ToCharArray());
            if (bSpecials2) AllowableChars.AddRange(strSpecials2.ToCharArray());

            if (AdditionalChars.Length > 0)
            {
                foreach(var c in AdditionalChars.Trim().ToCharArray())
                {
                    if (!AllowableChars.Contains(c))
                        AllowableChars.Add(c);
                }
            }

            if (AllowableChars.Count < 1)
                throw new ArgumentNullException("No characters selected!");

            return AllowableChars;    
        }

        public char[] GenerateAllowableCharsArray(string AdditionalChars = "")
        {
            return GenerateAllowableChars(AdditionalChars).ToArray();
        }

    }
}
