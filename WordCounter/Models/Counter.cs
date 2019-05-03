using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class Counter
  {
    public string UserWord {get; set;}
    public string UserSentence {get; set;}
    private string[] _userSentenceArray;
    public int WordMatches {get;}

      //Counter constructor
    public Counter(string userWord, string userSentence)
    {
      string letterOnlyWord = AlphabetOnly(userWord).ToLower();
      UserWord = letterOnlyWord;
      UserSentence = userSentence;

      string[] letterOnlySentence = SeperateSentenceWords(userSentence.ToLower());
      _userSentenceArray = letterOnlySentence;

      int wordMatches = FindMatches();
      WordMatches = wordMatches;
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
        if (UserWord == word)
        {
          wordMatches++;
        }
      }

      return wordMatches;
    }

    // Getters
    public string[] GetSentenceArray()
    {
      return _userSentenceArray;
    }

    // Setters
    public void SetSentenceElement(string newSentenceElement, int indexPosition)
    {
      _userSentenceArray[indexPosition] = newSentenceElement;
    }

  }
}
