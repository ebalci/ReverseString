using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseString
{
  class Program
  {
    static void Main( string[] args )
    {
      Console.Write( "Please Enter the string to reverse: " );
      string line = Console.ReadLine();
      Reverse reverse = new Reverse();

      do
      {
        Console.Write( "Reversed using a simple loop: " );
        Console.WriteLine( reverse.Rev(line) );

        Console.Write( "Reversed using recursion: " );
        Console.WriteLine( reverse.RecursiveRev(line) );

        Console.Write("Reversing a sentence: ");
        Console.WriteLine( reverse.ReverseSentence(line) );

        line = Console.ReadLine();
      }
      while ( line != String.Empty );
      
    }

  }
}
