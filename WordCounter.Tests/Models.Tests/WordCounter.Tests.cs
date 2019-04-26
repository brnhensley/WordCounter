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

    [TestMethod]
    public void SeperateSentenceWords_MakeArrayOfSentenceWords_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("Butts", "Cakes");
      string userSentence = "I am dyin here";

      // Act
      string[] sentenceArray = testInput.SeperateSentenceWords(userSentence);

      // Assert
      Assert.AreEqual("am", sentenceArray[1]);
    }

    //Test if both UserInputs are being converted by the constructor
    [TestMethod]
    public void UserInputs_RemoveNonAlphabeticalCharsFromBothUserInputs_True()
    {
      //Arrange
      UserInputs testObject = new UserInputs("!!fun!!", "hail 666satan666");

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
      UserInputs testObject = new UserInputs("Cat", "My CAT ate your cAT, and some other cats, cat CAt CATs.");

      // Act
      int wordMatches = testObject.FindMatches();

      // Assert
      Assert.AreEqual(4, wordMatches);
    }

    // Getter tests
    [TestMethod]
    public void GetWord_GetUserWord_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("butts", "cakes");

      // Act
      string testGetWord = testInput.GetWord();

      // Assert
      Assert.AreEqual("butts", testGetWord);
    }

    [TestMethod]
    public void GetSentence_GetUserSentence_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("butts", "cakes are yum");

      // Act
      string[] testGetSentence = testInput.GetSentence();

      // Assert
      Assert.AreEqual("yum", testGetSentence[2]);
    }

    // Tests both GetMatches and if the UserInputs constructor is saving word matches.
    [TestMethod]
    public void GetMatches_ReturnsMatchCount_True()
    {
      // Arrange
      UserInputs testObject = new UserInputs("Cat", "My CAT ate your cAT, and some other cats, cat CAt Catapolt.");

      // Act
      int wordMatches = testObject.FindMatches();

      // Assert
      Assert.AreEqual(4, wordMatches);
    }

    [TestMethod]
    public void SetWord_ChangeUserWordString_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("butts", "cakes are yum");

      // Act
      testInput.SetWord("dingleberries");
      string newWord = testInput.GetWord();

      // Assert
      Assert.AreEqual("dingleberries", newWord);
    }

    [TestMethod]
    public void SetSentenceElement_ChangeSentenceElement_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("butts", "cakes are yum");

      // Act
      testInput.SetSentenceElement("dingleberries", 0);
      string[] newSentence = testInput.GetSentence();

      // Assert
      Assert.AreEqual("dingleberries", newSentence[0]);
    }

    [TestMethod]
    public void SetWordMatches_MakesWordMatchesEvil_True()
    {
      // Arrange
      UserInputs testInput = new UserInputs("butts", "cakes are yum");

      // Act
      testInput.SetWordMatches();
      int evilMatches = testInput.GetMatches();

      // Assert
      Assert.AreEqual(666, evilMatches);
    }

  }
}
