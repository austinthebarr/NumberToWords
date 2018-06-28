using System;
using System.Collections.Generic;
using System.Linq;

namespace Numbers2WordsApp.Models
  {
    public class Numbers2Words
    {
      private int _userNumber;

      Dictionary<int, string> onesPosition = new Dictionary<int, string>() {
        {0, "zero"}, {1, "one"},
        {2, "two"}, {3, "three"},
        {4, "four"}, {5, "five"},
        {6, "six"}, {7, "seven"},
        {8, "eight"}, {9, "nine"} };
      Dictionary<int, string> teensPosition = new Dictionary<int, string>() {
          {10, "ten"}, {11, "eleven"},
          {12, "twelve"}, {13, "thirteen"},
          {14, "fourteen"}, {15, "fifteen"},
          {16, "sixteen"}, {17, "seventeen"},
          {18, "eighteen"}, {19, "nineteen"},  };
      Dictionary<string, string> tensPosition = new Dictionary<string, string>() {
          {"1", "ten"}, {"2", "twenty"},
          {"3", "thirty"}, {"4", "fourty"},
          {"5", "fifty"}, {"6", "sixty"},
          {"7", "seventy"}, {"8", "eighty"},
          {"9", "ninety"} };


      public Numbers2Words(int theNumber)
      {
        _userNumber = theNumber;
      }
      public int GetNumber()
      {
        return _userNumber;
      }
      public void SetNumber(int newNumber)
      {
        _userNumber = newNumber;
      }

      public string IsSingleDigit()
      {
        string result = "WRONG!";
        int evaluate = this.GetNumber();
        foreach(KeyValuePair<int, string> number in onesPosition)
        {
          if(evaluate == number.Key)
          {
            result = number.Value;
          }
        }
        return result;
      }
      public string IsTeenNumber()
      {
        string result = "WRONG!";
        int evaluate = this.GetNumber();
        foreach(KeyValuePair<int, string> number in teensPosition)
        {
          if(evaluate == number.Key)
          {
            result = number.Value;
          }
        }
        return result;
      }

    }

    class Program
    {
      public static void Main()
      {
        string result = "You didn't enter a number between 0 and 19";
        Console.WriteLine("Enter a number from 0 to 19");
        Numbers2Words newWord = new Numbers2Words(int.Parse(Console.ReadLine()));
        if(newWord.GetNumber() >= 0 && newWord.GetNumber() <= 9)
        {
          result = newWord.IsSingleDigit();
        }
        else if(newWord.GetNumber() >=10 && newWord.GetNumber() <= 19)
        {
          result = newWord.IsTeenNumber();
        }
        Console.WriteLine(result);
      }
    }
}
