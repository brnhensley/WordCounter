using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class Counter
  {
    private string _userWord;
    private string _userSentence;
    private string[] _userSentenceArray;
    private int _wordMatches;

      //Counter constructor
    public Counter(string userWord, string userSentence)
    {
      string letterOnlyWord = AlphabetOnly(userWord).ToLower();
      _userWord = letterOnlyWord;
      _userSentence = userSentence;

      string[] letterOnlySentence = SeperateSentenceWords(userSentence.ToLower());
      _userSentenceArray = letterOnlySentence;

      int wordMatches = FindMatches();
      _wordMatches = wordMatches;
    }

    // Creates word array from sentence, sends function to remove non alphabetical letters
    public string[] SeperateSentenceWords(string sentenceToArray)
    {
      string[] sentenceArray = sentenceToArray.Split(' ');
      for(int i = 0; i < sentenceArray.Length; i++)
      {
        sentenceArray[i] = AlphabetOnly(sentenceArray[i]);
      }
      return sentenceArray;
    }

    //Removes non-alphabetical chars from the strings & returns them
    public string AlphabetOnly(string input)
    {
      string inputLetters = new String(input.Where(Char.IsLetter).ToArray());
      return inputLetters;
    }

    // Compares userWord to the elements of userSentence returns number of matches
    public int FindMatches()
    {
      int wordMatches = 0;

      foreach (string word in _userSentenceArray)
      {
        if (_userWord == word)
        {
          wordMatches++;
        }
      }

      return wordMatches;
    }

    // Getters
    public string GetWord()
    {
      return _userWord;
    }

    public string GetSentence()
    {
      return _userSentence;
    }

    public string[] GetSentenceArray()
    {
      return _userSentenceArray;
    }

    public int GetMatches()
    {
      return _wordMatches;
    }

    // Setters
    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }

    public void SetSentenceElement(string newSentenceElement, int indexPosition)
    {
      _userSentenceArray[indexPosition] = newSentenceElement;
    }

    // Takes no arguments because you can't choose what to set it to, I do.
    public void SetWordMatches()
    {
      _wordMatches = 666;
    }

  }
}
