// See https://aka.ms/new-console-template for more information

using RockPaperScissors;

var computerPlayer = new Computer();
var humanPlayer = new Human();

var playerList = new List<Player> { computerPlayer, humanPlayer };
foreach (var player in playerList)
{
    player.SetName();
    player.Choose();
}


Console.WriteLine($"{computerPlayer.Name} chose {computerPlayer.Choice}");
Console.WriteLine($"{humanPlayer.Name} chose {humanPlayer.Choice}");