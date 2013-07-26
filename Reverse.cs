using System;
using System.Text;

namespace ReverseString
{
    class Reverse
    {
        /// <summary>
        /// Reverses a string using a simple for loop
        /// </summary>
        /// <param name="text">The string to be reversed</param>
        /// <returns>The string with characters in reverse order</returns>
        public string Rev(string text)
        {
            StringBuilder reverse = new StringBuilder("");
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverse.Append(text[i]);
            }

            return reverse.ToString();
        }

        /// <summary>
        /// Reverses the order of the words in a sentence
        /// </summary>
        /// <param name="str">The input string</param>
        /// <returns>Returns the sentence with the words in reverse order</returns>
        public string ReverseSentence(string str)
        {
            str = Rev(str);
            // Reverse the entire line of text
            // Split the reversed sentence and store each word
            string[] words = str.Split(' ');

            StringBuilder sr = new StringBuilder("");
            // Now reverse every word back to there originals
            for (int i = 0; i < words.Length; i++)
            {
                sr.Append(Rev(words[i]) + " ");
            }

            // Remove the last whithespace
            sr.Remove(sr.Length - 1, 1); 
            return sr.ToString();
        }
    }
}
