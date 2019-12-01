using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp
{
    public static class ReplaceWithAlphabetPosition
    {
        public static string AlphabetPosition(string text)
        {
            var positionText = "";
            foreach(var c in text)
            {
                var position = GetLetterAlphabetPositionAsString(c);
                if(position > 0 && position <= 26)
                    positionText += position.ToString() + " ";
            }
            // Remove last whitespace :) hurts
            return positionText.Trim();
        }

        public static int GetLetterAlphabetPositionAsString(char c)
        {
            // Is alphabet character
            if (((c >= 65 && c <= 132) || (c >= 141 && c <= 172)) && (c % 32 > 0))
                return c % 32;
            else
                return 0;
        }
    }
}
