using WordCounter.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace WordCounter.Tests
{
  [TestClass]
  public class CheckerTest
  {

    [TestMethod] //test for spec #1
    public void CheckerConstructor_CreatesInstanceOfChecker_Checker()
    {
      Checker newChecker = new Checker("world");
      Assert.AreEqual(typeof(Checker), newChecker.GetType());
    }

    [TestMethod] //test for spec #2
    public void CheckerConstructor_CreatesInstanceOfCheckerWTwoParameters_Checker()
    {
      Checker newChecker = new Checker("world", "Hello world.");
      Assert.AreEqual(typeof(Checker), newChecker.GetType());
    }
    [TestMethod] //test for spec #3
    public void SplitString_SplitsSentenceIntoStringArray_StringArray()
    {
      string sentence = "hello world";
      Checker newChecker = new Checker("world", sentence);

      string[] result = newChecker.SplitString(sentence);
      string[] testArray = {"hello", "world"};

      Assert.AreEqual(result[0], testArray[0]);
    }

    [TestMethod] //test for spec #4

    public void WordCount_ReturnsNumberOfTimesWordAppearsInSentence_Int()
    {
      string sampleString = "Hello, world";
      Checker testChecker = new Checker("Hello", sampleString);
      string [] stringArray = testChecker.SplitString(sampleString);

      int wordCountResult = testChecker.WordCount(stringArray);

      Assert.AreEqual(1, wordCountResult);
    }

    [TestMethod] //test for spec #5
      public void WordCount_AccountsForFullWordsOnly_Int()
      {
       Checker newChecker = new Checker("cat", "I saw a cat and another cat in front of the cathedral");

      string [] stringArray = newChecker.SplitString("I saw a cat and another cat in front of the cathedral");

      int wordCountResult = newChecker.WordCount(stringArray);

      Assert.AreEqual(2, wordCountResult);

      }
  }
}