using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class RepeatCounter
  {


    public static int CountRepeats(string userInputWord, string userInputString)
    {
      int currentCount = 0;
      // handle upper-case input
      string userInputStringToLower = userInputString.ToLower();
      Console.WriteLine(userInputStringToLower, userInputString);

      // create an array of strings, split on whitespace
      string[] userInputAsArray = userInputStringToLower.Split(' ');

      //loop thru array, check each word for match
      foreach (string currentWord in userInputAsArray)
      {
        // Console.WriteLine("current word is: ", currentWord);

        if (currentWord == userInputWord)
        {
          // Console.WriteLine (" yes match");
          currentCount++;
        }
        else
        {
          currentCount = currentCount;
          // Console.WriteLine (" no match");
        }
      }
      return currentCount;
    }
  }
}
