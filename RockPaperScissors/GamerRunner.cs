using System.Diagnostics;

namespace RockPaperScissors;

public class GamerRunner
{
    private readonly List<Player> _playerList = [];
    public GamerRunner()
    {
        var computerPlayer = new Computer();
        var humanPlayer = new Human();
        
        _playerList.Add(computerPlayer);
        _playerList.Add(humanPlayer);
        
        foreach (var player in _playerList)
        {
            player.SetName();
            player.Choose();
        }
    }

    public void Run()
    {
        var isTie = Judge();

        while (isTie)
        {
            foreach (var player in _playerList)
            {
                player.Choose();
            }
            isTie = Judge();
        }
        
    }

    private bool Judge()
    {
        foreach (var player in _playerList)
        {
            player.StateChoice();
        }
        
        var choice = _playerList.First().Choice;
        if (_playerList.All(player => player.Choice == choice))
        {
            Console.WriteLine("It's a tie!");
            return true;
        }
        
        var winningChoices = new Dictionary<Choices, Choices>
        {
            {Choices.Rock, Choices.Scissors},
            {Choices.Scissors, Choices.Paper},
            {Choices.Paper, Choices.Rock}
        };
        
        if (winningChoices[_playerList[0].Choice] == _playerList[1].Choice)
        {
            Console.WriteLine($"{_playerList[0].Name} wins!");
            return false;
        }
        Console.WriteLine($"{_playerList[1].Name} wins!");
        return false;
    }
}