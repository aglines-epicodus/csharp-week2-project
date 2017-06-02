using Xunit;
using System;
using System.Collections.Generic;

namespace Wordcount
{
  public class WordcountTests
  {
    // | Input  "a", "a" | Output 1 |
    [Fact]
    public void CountRepeats_SingleWordInput_Returns1()
    {
      //Arrange
      string testInputString = "a";
      string testInputWord = "a";
      int expectedCount = 1;
      //Act
      int result = RepeatCounter.CountRepeats(testInputWord, testInputString);
      //Assert
      Assert.Equal(expectedCount, result);
    }

    // | Input  "A", "a" | Output 1 |
    [Fact]
    public void CountRepeats_UpperCaseInput_Returns1()
    {
      string testInputString = "A";
      string testInputWord = "a";
      int expectedCount = 1;
      int result = RepeatCounter.CountRepeats(testInputWord, testInputString);
      Assert.Equal(expectedCount, result);
    }

    // | Input  "a a", "a" | Output 2 |
    [Fact]
    public void CountRepeats_TwoExamplesInput_Returns2()
    {
      string testInputString = "a a";
      string testInputWord = "a";
      int expectedCount = 2;
      int result = RepeatCounter.CountRepeats(testInputWord, testInputString);
      Assert.Equal(expectedCount, result);
    }
  }
}
