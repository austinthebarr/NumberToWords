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
    public void SingleDigit_ReturnsCorrectWordFive_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(5);
      //Act
      string result = newNum.SingleDigit();
      //Assert
      Assert.AreEqual(result, "five");
    }
    [TestMethod]
    public void SingleDigit_ReturnsCorrectWordZero_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(0);
      //Act
      string result = newNum.SingleDigit();
      //Assert
      Assert.AreEqual(result, "zero");
    }
    [TestMethod]
    public void SingleDigit_ReturnsCorrectWordNine_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(9);
      //Act
      string result = newNum.SingleDigit();
      //Assert
      Assert.AreEqual(result, "nine");
    }
    // [TestMethod]
    // public void StringToInt_ConvertsStringToInt_True()
    // {
    //   //Assign
    //   Numbers2Words newNum = new Numbers2Words(9);
    //   int expected = 9;
    //   //Act
    //   string result = newNum.StringToInt();
    //   //Assert
    //   Assert.AreEqual(expected, result);
    // }
  }
}
