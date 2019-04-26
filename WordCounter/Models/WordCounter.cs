using System;
using System.Collections.Generic;

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
      _userWord = userWord;
      _userSentence = userSentence;
    }

    //Removes non-alphabetical chars from the strings & returns them - input is a stand in for both object strings.
    public string AlphabetOnly(string input)
    {
      return input;
    }

  }
}
