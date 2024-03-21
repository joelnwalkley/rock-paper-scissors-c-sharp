// See https://aka.ms/new-console-template for more information

using RockPaperScissors;

Console.WriteLine("Hello, World!");

var computerPlayer = new Computer();
var humanPlayer = new Human("Human");

var playerList = new List<Player> { computerPlayer, humanPlayer };
foreach (var player in playerList)
{
    player.Choose();
}


Console.WriteLine($"{computerPlayer.Name} chose {computerPlayer.Choice}");
Console.WriteLine($"{humanPlayer.Name} chose {humanPlayer.Choice}");