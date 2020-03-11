using System;
using WordCounter.Models;


namespace WordCounter
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("enter word");
      string word = Console.ReadLine();
      Console.WriteLine("enter sentence");
      string sentence = Console.ReadLine();
      Checker newChecker = new Checker(word, sentence);
      Console.WriteLine(newChecker.Sentence);
      int wordCount = newChecker.WordCount(sentence);
      Console.WriteLine(wordCount);
      // Console.WriteLine(newChecker.WordCount(array));

      
    }
  }
  }