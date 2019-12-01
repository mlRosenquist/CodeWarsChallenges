using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.FindOddOccuringInt
{
    public static class FindOddOccuringInt
    {
        public static int find_it(int[] seq)
        {
            foreach(var value in seq)
            {
                var filteredSeq = Array.FindAll(seq, x => x == value);

                if ((filteredSeq.Length % 2) != 0)
                    return value;
            }
            return -1;
        }
    }
}
