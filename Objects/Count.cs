using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class RepeatCounter
  {


    public static int CountRepeats(string userInputWord, string userInputString)
    {
      // accept two strings as input
      // split one on whitespace - tho this is NEXT test
      // create an array of strings, split on whitespace
      string userInputStringToLower = userInputString.ToLower();
      Console.WriteLine(userInputStringToLower, userInputString);
      // string[] userInputAsArray = userInputString.Split(' ');
      // foreach (string word in userInputAsArray)
      // {
      //   Console.WriteLine(word);
      // check whether string2 is present, whole-word fashion, in str1
      // for now, THIS is the code that will pass the test
      // I don't need some "contains" method, just need equals
      if (userInputWord == userInputStringToLower)
      {
        return 1;
      }

      else
      {
        return 0;
      }
      // }



      // return the number of times it is present


      // i suppose you split the input on whitespace,
      // feed into an ... array? list? ugh figure it out andy
      // loop thru array, incrementing count each time it hits

    }
  }
}
