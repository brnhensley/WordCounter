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
      _userWord = userWord;
      _userSentence = userSentence;
    }

  }
}
