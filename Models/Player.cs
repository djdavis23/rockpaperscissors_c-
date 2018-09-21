namespace rock_paper_scissors.Models
{
  public class Player
  {
    //Props
    public string Name { get; set; }
    public int GamesPlayed { get; private set; }
    public int GamesWon { get; private set; }

    //Methods
    public void WonGame()
    {
      this.GamesPlayed++;
      this.GamesWon++;
    }

    public void LostGame() => this.GamesPlayed++;

    //Constructor
    public Player(string name)
    {
      this.Name = name;
      this.GamesPlayed = 0;
      this.GamesWon = 0;
    }
  }
}