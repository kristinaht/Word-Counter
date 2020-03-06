using System;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class GameTest
  {
    [TestMethod]
    public void GameConstructor_CreatesInstanceOfGame_Game()
    {
      Game newGame = new Game("world");
      string testUserInput = "world";
      Assert.AreEqual(typeof(testUserInput), getType(newGame.Word));
    }

  }
}