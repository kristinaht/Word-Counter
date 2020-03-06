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

  }
}