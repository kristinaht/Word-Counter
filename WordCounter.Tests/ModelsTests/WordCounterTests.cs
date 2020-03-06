using System;
using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

  }
}