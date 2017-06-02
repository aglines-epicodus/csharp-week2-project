using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class RepeatCounter
  {
    public static int CountRepeats(string userInputWord, string userInputString)
    {
      int currentCount = 0;
      string userInputStringToLower = userInputString.ToLower();
      string[] userInputAsArray = userInputStringToLower.Split(' ');
      foreach (string currentWord in userInputAsArray)
      {
        if (currentWord == userInputWord)
        {
          currentCount++;
        }
        else
        {
          currentCount = currentCount;
          // I acknowledge I keep receiving a warning on this line
        }
      }
      return currentCount;
    }
  }
}
