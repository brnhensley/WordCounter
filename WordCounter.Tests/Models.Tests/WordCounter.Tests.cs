using System.Collections.Generic;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.TestTools
{
  [TestClass]
  public class WordCounterTest
  {
    [TestMethod]
    public void UserInputs_CreateObjectOfWordAndSentece_True()
    {
      // Arrange
      // Act
      UserInputs testObject = new UserInputs("jackalope", "Where are my keys");
      // Assert
      Assert.AreEqual(typeof(UserInputs), testObject.GetType());
    }

    [TestMethod]
    public void AlphabetOnly_RemoveNonAlphabeticalChars_True()
    {
      //Arrange
      UserInputs testObject = new UserInputs("jackalope", "Where are my keys");
      string testWord = "GROSS!1!";
      //Act
      string newTestWord = testObject.AlphabetOnly(testWord);
      // Assert
      Assert.AreEqual(testWord, "GROSS");
    }
  }
}
