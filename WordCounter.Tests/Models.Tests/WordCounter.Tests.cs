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
    public void UserInputs_CreateObjectOfWordAndSentece_UserInputs()
    {
      UserInputs testObject = new UserInputs("jackalope", "Where are my keys");
      Assert.AreEqual(typeof(UserInputs), testObject.GetType());
    }

  }
}
