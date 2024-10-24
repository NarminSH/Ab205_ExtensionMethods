using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab205_ExtensionMethods
{
    public static class CustomExtension
    {
        public static int Add(this int num1, int num2)
        {
            return num1 + num2;
        }

        public static string ToUpperCase(this string word)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(char.ToUpper(word[0]));
            sb.Append(word.Substring(1, word.Length-1).ToLower());
            return sb.ToString();
        }


    }
}
