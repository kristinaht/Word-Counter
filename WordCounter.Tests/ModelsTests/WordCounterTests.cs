using System;
using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("world");
      
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGameWTwoParameters_Game()
    {
      Game newGame = new Game("world", "Hello world.");
      
      Assert.AreEqual(typeof(Game), newGame.GetType());
    }

    [TestMethod]

    public void SplitString_SplitStringIntoStringArray_StringArray()
    {
      Game newGame = new Game("hi", "Today is Friday.");
      string[] result = Game.SplitString("Today is Friday.");
      CollectionAssert.AreEqual(result, newGame.SplitString("Today is Friday."));
    }

  }
}