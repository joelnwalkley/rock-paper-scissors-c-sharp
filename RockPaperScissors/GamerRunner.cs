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
        
        // rock beats scissors, scissors beats paper, paper beats rock
       

        Console.WriteLine("there is a winner, I just don't know which one yet...");
        return false;
        // else if (_playerList[0].Choice == "Rock" && _playerList[1].Choice == "Scissors")
        // {
        //     Console.WriteLine($"{_playerList[0].Name} wins!");
        //     return true;
        // }
        // else if (_playerList[0].Choice == "Paper" && _playerList[1].Choice == "Rock")
        // {
        //     Console.WriteLine($"{_playerList[0].Name} wins!");
        //     return true;
        // }
        // else if (_playerList[0].Choice == "Scissors" && _playerList[1].Choice == "Paper")
        // {
        //     Console.WriteLine($"{_playerList[0].Name} wins!");
        //     return true;
        // }
        // else
        // {
        //     Console.WriteLine($"{_playerList[1].Name} wins!");
        //     return true;
        // }
    }
}