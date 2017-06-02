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
      string testInput = "a";
      int expectedCount = 1;
      //Act
      int result = RepeatCounter.CountRepeats(testInput);
      //Assert
      Assert.Equal(expectedCount, result);
    }
  }
}
