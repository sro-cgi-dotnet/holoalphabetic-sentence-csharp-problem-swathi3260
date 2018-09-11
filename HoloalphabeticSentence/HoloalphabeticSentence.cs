using System;
using System.Linq;

namespace HoloalphabeticSentence
{
    public class HoloalphabeticSentence
    {
        // Write the logic to determine whether the input string is a HoloalphabeticSentence or not
        public static bool IsHoloalphabeticSentence(string input, string alphabets = "abcdefghijklmnopqrstuvwxyz")
        {
            input = input.ToLower();
            int len = input.Length;
            int alpha = 0;
            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    if (alphabets[i] == input[j])
                    {
                        alpha = alpha + 1;
                        break;
                    }
                }
            }
            if (alpha == 26)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
