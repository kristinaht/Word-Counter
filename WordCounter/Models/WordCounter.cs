namespace WordCounter.Models
{
  public class Checker
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public Checker(string word)
    {
      Word = word;
    }
    public Checker(string word, string sentence)
    : this(word)
    {
      Sentence = sentence;
    }
    
    public string[] SplitString(string sentence)
    {
      char[] splitters = { ' ', ',', '.', ':' };
      string[] stringArray = Sentence.Split(splitters);
      return stringArray;
    }

    public int WordCount(string[] stringArray) 
    {
      // char[] splitters = { ' ', ',', '.', ':' };
      // string[] stringArray = Sentence.Split(splitters);
      int wordCount = 0;
      foreach(string item in stringArray)
      {
        if(item == Word)
        {
          wordCount++;
        }
      }
      return wordCount;
    }
  }
}