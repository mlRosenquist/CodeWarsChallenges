using System;
using System.Linq;


namespace CSharp.VowelCount
{
    public static class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            return str.Count(x => x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u');
        }
    }
}
