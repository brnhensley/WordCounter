using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class CounterController : Controller
  {
    [HttpGet("/counter/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counter")]
    public ActionResult Index(string userWord, string userSentence)
    {
      Counter myCounter = new Counter(userWord, userSentence);
      return View(myCounter);//, allWords);
      //I was not able to get this word list working before deadline
      // List<Counter> allWords = Counter.GetAll();
    }

  }
}
