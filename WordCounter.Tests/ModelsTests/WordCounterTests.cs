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

    public void WordCount_SplitStringIntoStringArray_StringArray()
    {
      string sampleString = "Hello, world";
      Game testGame = new Game("Hello", sampleString);
      Assert.AreEqual(1, testGame.WordCount(sampleString));
    }
   
  }
}