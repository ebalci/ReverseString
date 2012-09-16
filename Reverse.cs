using System;
using System.Collections.Generic;
using System.Linq;
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
    public string Rev( string text )
    {     
      char[] cArray = text.ToCharArray();
      string reverse = String.Empty;
      for ( int i = 1; i <= cArray.Length; i++ )
      {
        reverse += cArray[cArray.Length - i];
      }

      return reverse;
    }

    /// <summary>
    /// Reverses a string using recursion
    /// </summary>
    /// <param name="text">The string to be reversed</param>
    /// <returns>The string with characters in reverse order</returns>
    public string RecursiveRev( string str )
    {
      // Return when the end of the string is reached
      if ( (str == null) || (str.Length <= 1) )
      {
        return str;
      }
      
      // Substring starting at index 1 + first character on the end
      return RecursiveRev( str.Substring(1) ) + str[0];
    }

    /// <summary>
    /// Reverses the order of the words in a sentence
    /// </summary>
    /// <param name="str">The input string</param>
    /// <returns>Returns the sentence with the words in reverse order</returns>
    public string ReverseSentence( string str )
    {
      // Reverse the entire line of text
      str = RecursiveRev(str);
      // Split the reversed sentence and store each word
      string[] words = str.Split(' ');

      str = String.Empty;
      // Now reverse every word back to there originals
      for( int i=0; i< words.Length; i++ )
      {
        str += RecursiveRev(words[i]) + " ";
      }

      return str;
    }
  }
}
