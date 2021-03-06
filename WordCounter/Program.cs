using System;
using WordCounter.Models;


namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Word Checker!");
      Console.WriteLine("Enter a word");
      string wordMix = Console.ReadLine();
      string word = wordMix.ToLower();
      Console.WriteLine("Enter a sentence");
      string sentenceMix = Console.ReadLine();
      string sentence = sentenceMix.ToLower();
      Checker newChecker = new Checker(word, sentence);
      Console.WriteLine(newChecker.Sentence);
      Console.WriteLine(newChecker.WordCount(newChecker.SplitString(sentence)));
    }
  }
  }