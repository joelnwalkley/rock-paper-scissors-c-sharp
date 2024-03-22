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
        while (true)
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

            Console.Write("Play again? (Y/n): ");
            var playAgain = Console.ReadKey().Key;
            if (playAgain is ConsoleKey.Y or ConsoleKey.Enter)
            {
                Console.WriteLine();
                foreach (var player in _playerList)
                {
                    player.Choose();
                }
                continue;
            }

            break;
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

        var outcomes = new List<Outcome>
        {
            new (Choice.Rock, Choice.Scissors, "Rock crushes Scissors"),
            new (Choice.Scissors, Choice.Paper, "Scissors cut Paper"),
            new (Choice.Paper, Choice.Rock, "Paper covers Rock")
        };

        foreach (var outcome in outcomes)
        {
            if (outcome.Winner == _playerList[0].Choice && outcome.Loser == _playerList[1].Choice)
            {
                Console.WriteLine(outcome.Reason);
                Console.WriteLine($"{_playerList[0].Name} wins!");
            }

            if (outcome.Winner != _playerList[1].Choice || outcome.Loser != _playerList[0].Choice) continue;
            Console.WriteLine(outcome.Reason);
            Console.WriteLine($"{_playerList[1].Name} wins!");
        }

        return false;
    }
}