using System;
using rock_paper_scissors.Models;

namespace rock_paper_scissors
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Console.WriteLine("Hello! What is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Nice to meet you {name}!  Would you like to play a game of rock-paper-scissors (Y/N)?");
      string response = Console.ReadLine().ToUpper();
      //If player doesn't want to play, exit program
      if (response != "Y")
      {
        Console.WriteLine($"OK, have a great day {name}.  Goodbye!");
        return;
      }
      //initiate Game
      Player player = new Player(name);

      while (response == "Y")
      {
        Game game = new Game(player);
        Console.WriteLine("Please make your selection: 'rock', 'paper' or 'scissors'");
        string choice = Console.ReadLine().ToLower();

        //check for valid selection
        while (!game.IsValidChoice(choice))
        {
          Console.WriteLine("Invalid selection.  Please choose 'rock', 'paper', or 'scissors'");
          choice = Console.ReadLine().ToLower();
        }

        //Play Game
        Console.WriteLine(game.PlayGame(choice));
        Console.WriteLine("Do you wish to play again (Y/N)?");
        response = Console.ReadLine().ToUpper();
      }
      Console.WriteLine($"OK, you won {player.GamesWon} out of {player.GamesPlayed} games.");
      Console.WriteLine($"Have a great day {player.Name}!");
    }
  }
}
