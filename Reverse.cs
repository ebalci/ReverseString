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
    public string RecursiveRev( string s )
    {
      // Return when the end of the string is reached
      if ( (s == null) || (s.Length <= 1) )
      {
        return s;
      }
      
      // Substring starting at index 1 + first character on the end
      return RecursiveRev( s.Substring(1) ) + s[0];
    }
  }
}
