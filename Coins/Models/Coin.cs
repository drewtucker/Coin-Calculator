using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;

namespace CoinsApp.Models
{
  public class Coin
  {
    public List<int> CoinCheck(int userInput)
    {
      List<int> coinList = new List<int>();

      coinList.Add(userInput / 25);
      int remainder = userInput % 25;

      coinList.Add(remainder / 10);
      remainder = remainder % 10;

      coinList.Add(remainder / 5);
      remainder = remainder % 5;

      coinList.Add(remainder);

      return coinList;
    }
  }
}
