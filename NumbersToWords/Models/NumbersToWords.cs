using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers2WordsApp.Models
  {
    public class Numbers2Words
    {
      private string _userNumber;

      Dictionary<string, string> onesPosition = new Dictionary<string, string>() {
        {"1", "one"}, {"2", "two"},
        {"3", "three"}, {"4", "four"},
        {"5", "five"}, {"6", "six"},
        {"7", "seven"}, {"8", "eight"},
        {"9", "nine"} };
      Dictionary<string, string> teensPosition = new Dictionary<string, string>() {
          {"1", "eleven"}, {"2", "twelve"},
          {"3", "thirteen"}, {"4", "fourteen"},
          {"5", "fifteen"}, {"6", "sixteen"},
          {"7", "seventeen"}, {"8", "eighteen"},
          {"9", "nineteen"} };
      Dictionary<string, string> tensPosition = new Dictionary<string, string>() {
          {"1", "ten"}, {"2", "twenty"},
          {"3", "thirty"}, {"4", "fourty"},
          {"5", "fifty"}, {"6", "sixty"},
          {"7", "seventy"}, {"8", "eighty"},
          {"9", "ninety"} };


      public Numbers2Words(string theNumber)
      {
        _userNumber = theNumber;
      }
      public string GetNumber()
      {
        return _userNumber;
      }
      public void SetNumber(string newNumber)
      {
        _userNumber = newNumber;
      }

      public string SingleDigit()
      {
        string result = "WRONG!";
        string evaluate = this.GetNumber();
        foreach(KeyValuePair<string, string> number in onesPosition)
        {
          if(evaluate == number.Key)
          {
            result = number.Value;
          }
        }
        return result;
      }

    }
}
