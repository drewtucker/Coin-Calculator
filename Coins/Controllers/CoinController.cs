using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using CoinsApp.Models;

namespace CoinsApp.Controllers
{
  public class CoinsAppController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      // List<int> newCoinList = Coin.GetAll();
      return View();
    }

    [HttpGet("/coin/form")]
    public ActionResult CoinForm()
    {
      return View();
    }

    [HttpPost("/coin/display")]
    public ActionResult Display()
    {
      Coin newCoin = new Coin();
      int userInput = Int32.Parse(Request.Form["input-change"]);
      List<int> newCoinList = newCoin.CoinCheck(userInput);
      return View("Index", newCoinList);
    }

  }
}
