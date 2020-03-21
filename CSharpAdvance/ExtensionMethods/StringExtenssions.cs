using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpAdvance.ExtensionMethods
{
    /// <summary>
    /// Class created to inherid from String.
    /// </summary>
    public static class StringExtenssions // First name of the class and then name Extenssions.
    {
        // Always shut be public static.
        // First argument es 'this', de second is the class and thrid one name.
        public static string Shorten(this String srt, int numberOfWords)
        {
            if (numberOfWords < 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords should be greater or equal to 0.");
            }

            // If numberOfWords equal to 0, return empty.
            if (numberOfWords == 0)
            {
                return string.Empty;
            }

            // We get text here.
            var words = srt.Split(' ');

            // If length is less than numberOfWords, return 
            if (words.Length <= numberOfWords)
            {
                return srt;
            }

            // If there are more than numberOfWords, return only numberOfWords.
            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}
