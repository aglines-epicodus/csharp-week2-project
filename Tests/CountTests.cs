using Xunit;
using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class WordcountTests
  {
    [Fact]
    public void CountRepeats_SingleWordInput_Returns1()
    {
      //Arrange
      string testInputWord = "a";
      string testInputString = "a";
      int expectedCount = 1;
      //Act
      int result = RepeatCounter.CountRepeats(testInputWord, testInputString);
      //Assert
      Assert.Equal(expectedCount, result);
    }

    [Fact]
    public void CountRepeats_UpperCaseInput_Returns1()
    {
      string testInputWord = "A";
      string testInputString = "a";
      int expectedCount = 1;
      int result = RepeatCounter.CountRepeats(testInputWord, testInputString);
      Assert.Equal(expectedCount, result);
    }




  }
}
