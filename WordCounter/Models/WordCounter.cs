using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class UserInputs
  {
    private string _userWord;
    private string[] _userSentence;

    //UserInputs constructor
    public UserInputs(string userWord, string userSentence)
    {
      string letterOnlyWord = AlphabetOnly(userWord);
      _userWord = letterOnlyWord;

      string[] letterOnlySentence = SeperateSentenceWords(userSentence); //move into SeperateSentenceWords() ?
      _userSentence = letterOnlySentence;
    }

    // Creates word array from sentence, sends function to remove non alphabetical letters
    public string[] SeperateSentenceWords(string sentenceToArray)
    {
      string[] sentenceArray = sentenceToArray.Split(' ');
      for(int i = 0 ; i < sentenceArray.Length ; i++)
        {
          sentenceArray[i] = AlphabetOnly(sentenceArray[i]);
        }
      return sentenceArray;
    }

    //Removes non-alphabetical chars from the strings & returns them - input is a stand in for both object property strings.
    public string AlphabetOnly(string input)
    {
      //Need to convert sentece to a word Array first, then try to run this on the array elements, then convert that array back to a string.
      string inputLetters = new String(input.Where(Char.IsLetter).ToArray());
      return inputLetters;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public string[] GetSentence()
    {
      return _userSentence;
    }


  }
}

  /// AlphabetOnly IS GOING TO REMOVE ALL SPACES TOO! FUCK!
