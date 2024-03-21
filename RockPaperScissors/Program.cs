// See https://aka.ms/new-console-template for more information

using RockPaperScissors;

Console.WriteLine("Hello, World!");

var player = new Computer("Computer");
player.Choose();

Console.WriteLine($"{player.Name} chose {player.Choice}");