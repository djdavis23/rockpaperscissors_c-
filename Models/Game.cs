using System;
using System.Collections.Generic;

namespace rock_paper_scissors.Models
{

  public class Game
  {
    private Random _rand;

    public Player player { get; set; }
    private Dictionary<string, string> ValidChoices;

    public Random Getrand()
    {
      return _rand;
    }

    public void Setrand(Random value) => _rand = value;

    public Boolean IsValidChoice(string choice)
    {
      return ValidChoices.ContainsKey(choice);
    }

    public string PlayGame(string choice)
    {
      //set computer selectin
      string[] choices = new string[3] { "rock", "paper", "scissors" };
      string compSelect = choices[_rand.Next(choices.Length)];

      //determine outcome
      if (compSelect == choice)
      {
        player.LostGame();
        return ($"You chose: {choice}, Computer chose: {compSelect} ...You tied!");
      }
      else if (compSelect == ValidChoices[choice])
      {
        player.LostGame();
        return ($"You chose: {choice}, Computer chose: {compSelect} ...You lost!");
      }
      player.WonGame();
      return ($"You chose: {choice}, Computer chose: {compSelect} ...You won!");
    }

    public Game(Player player)
    {
      this.player = player;
      this.ValidChoices = new Dictionary<string, string>();
      ValidChoices.Add("rock", "paper");
      ValidChoices.Add("paper", "scissors");
      ValidChoices.Add("scissors", "rock");
      this._rand = new Random();

    }
  }
}