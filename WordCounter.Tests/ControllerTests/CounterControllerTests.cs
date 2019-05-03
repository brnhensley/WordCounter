using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WordCounter.Controllers;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class CounterControllerTest
  {
    [TestMethod]
    public void Index_ReturnsCorrectView_True()
    {
      //Arrange
      CounterController controller = new CounterController();

      //Act
      ActionResult indexView = controller.Index("farts", "more farts");

      //ASSERT
      Assert.IsInstanceOfType(indexView, typeof(ViewResult));

    }

  }
}
