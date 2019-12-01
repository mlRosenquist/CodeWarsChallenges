using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.CreditCardMask
{
    public static class CreditCardMask
    {
        // return masked string
        public static string Maskify(string cc)
        {
            var maskedString = cc;

            if(cc.Length > 4)
            {
                var hashTags = "";
               for(var i = 0; i < cc.Length - 4; i++)
                {
                    hashTags += "#";
                }
                maskedString = hashTags + cc.Substring(cc.Length - 4, 4);   
            }
            return maskedString;
        }
    }
}
