using System;
using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class CheckerTest
  {

    [TestMethod]
    public void CheckerConstructor_CreatesInstanceOfChecker_Checker()
    {
      Checker newChecker = new Checker("world");
      
      Assert.AreEqual(typeof(Checker), newChecker.GetType());
    }

    [TestMethod]
    public void CheckerConstructor_CreatesInstanceOfCheckerWTwoParameters_Checker()
    {
      Checker newChecker = new Checker("world", "Hello world.");
      
      Assert.AreEqual(typeof(Checker), newChecker.GetType());
    }

    [TestMethod]

    public void WordCount_SplitStringIntoStringArray_StringArray()
    {
      string sampleString = "Hello, world";
      Checker testChecker = new Checker("Hello", sampleString);
      Assert.AreEqual(1, testChecker.WordCount(sampleString));
    }
  }
}