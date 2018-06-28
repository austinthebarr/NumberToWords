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
    public void IsSingleDigit_ReturnsCorrectWordFive_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(5);
      //Act
      string result = newNum.IsSingleDigit();
      //Assert
      Assert.AreEqual(result, "five");
    }
    [TestMethod]
    public void IsSingleDigit_ReturnsCorrectWordZero_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(0);
      //Act
      string result = newNum.IsSingleDigit();
      //Assert
      Assert.AreEqual(result, "zero");
    }
    [TestMethod]
    public void IsSingleDigit_ReturnsCorrectWordNine_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(9);
      //Act
      string result = newNum.IsSingleDigit();
      //Assert
      Assert.AreEqual(result, "nine");
    }
    [TestMethod]
    public void IsTeenNumber_ReturnsCorrectWordTen_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(10);
      //Act
      string result = newNum.IsTeenNumber();
      //Assert
      Assert.AreEqual(result, "ten");
    }
    [TestMethod]
    public void IsTeenNumber_ReturnsCorrectWordFifteen_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(15);
      //Act
      string result = newNum.IsTeenNumber();
      //Assert
      Assert.AreEqual(result, "fifteen");
    }
    [TestMethod]
    public void IsTeenNumber_ReturnsCorrectWordEighteen_True()
    {
      //Assign
      Numbers2Words newNum = new Numbers2Words(18);
      //Act
      string result = newNum.IsTeenNumber();
      //Assert
      Assert.AreEqual(result, "eighteen");
    }


  }
}
