using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoinsApp;
using System.Collections.Generic;
using CoinsApp.Models;

namespace CoinsApp.Tests
{
  [TestClass]
  public class CoinsAppTest
  {
    [TestMethod]
    public void TestCoinCheck()
    {
      Coin newCoin = new Coin();
      List<int> setValuesCoinList = new List<int>{0,0,0,0};
      CollectionAssert.AreEqual(setValuesCoinList, newCoin.CoinCheck(0));
    }
  }
}
