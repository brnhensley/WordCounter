using System;
using System.Collections.Generic;
using System.Linq;

namespace WordCounter.Models
{

  public class UserInputs
  {
    private string _userWord;
    private string _userSentence;

    //UserInputs constructor
    public UserInputs(string userWord, string userSentence)
    {
      //Run both inputs though AlphabetOnly
      string letterOnlyWord = AlphabetOnly(userWord);
      _userWord = letterOnlyWord;
      string letterOnlySentence = AlphabetOnly(userSentence);
      _userSentence = letterOnlySentence;
    }

    //Removes non-alphabetical chars from the strings & returns them - input is a stand in for both object strings.
    public string AlphabetOnly(string input)
    {
      string inputLetters = new String(input.Where(Char.IsLetter).ToArray());
      return inputLetters;
    }

    public string GetWord()
    {
      return _userWord;
    }

    public string GetSentence()
    {
      return _userSentence;
    }


  }
}

  /// AlphabetOnly IS GOING TO REMOVE ALL SPACES TOO! FUCK!
