using System;
using System.Text.RegularExpressions;

namespace Text
{
     /// <summary>Str Class</summary>
    public class Str
    {
        /// <summary>Find if a string is palindrome</summary>
        /// <param name="s">List to palindrome.</param>
        /// <returns>true or false.</returns>
        public static bool IsPalindrome(string s)
        {
            if(s.Length < 2)
            {
                return(true);
            }

            s = s.ToLower();

            s = Regex.Replace(s, "[:;,. \t\n\r]", "");

            //Console.WriteLine(s);

            char[] revArr= s.ToCharArray();
            Array.Reverse(revArr);

            //Console.WriteLine(revArr);

            for(int x = 0; x < s.Length; x++)
            {
                if(s[x] != revArr[x])
                {
                    //Console.WriteLine("its false");
                    return(false);
                }
                
            }
            return (true);
        }
    }
}