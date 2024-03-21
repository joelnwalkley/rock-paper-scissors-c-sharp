// See https://aka.ms/new-console-template for more information

using RockPaperScissors;

Console.WriteLine("Hello, World!");

var player1 = new Computer("Computer1");
var player2 = new Computer("Computer2");

var playerList = new List<Player> { player1, player2 };
foreach (var player in playerList)
{
    player.Choose();
}

Console.WriteLine($"{player1.Name} chose {player1.Choice}");
Console.WriteLine($"{player2.Name} chose {player2.Choice}");