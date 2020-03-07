namespace WordCounter.Models
{
  public class Game
  {
    public string Word { get; set; }
    public string Sentence { get; set; }

    public Game(string word)
    {
        Word = word;
    }
    public Game(string word, string sentence)
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

    public int WordCount()
    {
      int wordCount = 0;
      foreach(string item in stringArray)
      {
        if(item == Word)
        {
          wordCount++;
        }
        return wordCount;
      }
    }
  }
}