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
      string testWord = "GROSS!1! HAM";

      //Act
      string lettersTestWord = testObject.AlphabetOnly(testWord);

      // Assert
      Assert.AreEqual("GROSSHAM", lettersTestWord);
    }

    // Getter test
    [TestMethod]
    public void GetWord_GetUserWord_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("Butts", "Cakes");

      // Act
      string testGetWord = testInput.GetWord();

      // Assert
      Assert.AreEqual("butts", testGetWord);
    }

    [TestMethod]
    public void GetSentence_GetUserSentence_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("Butts", "Cakes are yum");

      // Act
      string[] testGetSentence = testInput.GetSentence();

      // Assert
      Assert.AreEqual("yum", testGetSentence[2]);
    }

    [TestMethod]
    public void SeperateSentenceWords_MakeArrayOfSentenceWords_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("Butts", "Cakes");
      string userSentence = "I am dyin' here";

      // Act
      string[] sentenceArray = testInput.SeperateSentenceWords(userSentence);

      // Assert
      Assert.AreEqual("dyin", sentenceArray[2]);
    }

    //Test if both UserInputs are being converted by the constructor
    [TestMethod]
    public void UserInputs_RemoveNonAlphabeticalCharsFromBothUserInputs_True()
    {
      //Arrange
      UserInputs testObject = new UserInputs("!!FUN!!", "Hail Satan666");

      //Act
      string testWord = testObject.GetWord();
      string[] testSentence = testObject.GetSentence();

      // Assert
      Assert.AreEqual("fun", testWord);
      Assert.AreEqual("satan", testSentence[1]);
    }

    //Test to Compare userWord and userSentence
    [TestMethod]
    public void FindMatches_CompareWordToSentence_True()
    {
      // Arrange
      UserInputs testObject = new UserInputs("Cat", "My CAT ate your cAT, and some other cats, cat CAt cats.");

      // Act
      int wordMatches = testObject.FindMatches();

      // Assert
      Assert.AreEqual(4, wordMatches);
    }

  }
}
