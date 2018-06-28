using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numbers2WordsApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace Numbers2WordsApp.Test
{
  [TestClass]
  public class Numbers2WordsTest
  {
    [TestMethod]
    public void SingleDigit_ReturnsCorrectWord_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words("5");
      //Act
      string result = newNum.SingleDigit();
      //Assert
      Assert.AreEqual(result, "five");
    }
  }
}
