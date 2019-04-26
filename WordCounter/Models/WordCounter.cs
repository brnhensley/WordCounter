using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class UserInputs
  {
    private string _userWord;
    private string[] _userSentence;
    private int _wordMatches;

    //UserInputs constructor
    public UserInputs(string userWord, string userSentence)
    {
      string letterOnlyWord = AlphabetOnly(userWord).ToLower();
      _userWord = letterOnlyWord;

      string[] letterOnlySentence = SeperateSentenceWords(userSentence.ToLower());
      _userSentence = letterOnlySentence;

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

      for(int i = 0; i < _userSentence.Length; i++)
      {
        if (_userWord == _userSentence[i])
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

    public string[] GetSentence()
    {
      return _userSentence;
    }

    public int GetMatches()
    {
      return _wordMatches;
    }

    public void SetWord(string newWord)
    {
      _userWord = newWord;
    }


  }
}
