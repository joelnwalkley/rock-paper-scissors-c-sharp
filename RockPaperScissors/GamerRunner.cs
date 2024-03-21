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

            Console.Write("Play again? (Y/N): ");
            var playAgain = Console.ReadLine();
            if (playAgain?.ToUpper() is "Y")
            {
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
            new Outcome(Choices.Rock, Choices.Scissors, "Rock crushes Scissors"),
            new Outcome(Choices.Scissors, Choices.Paper, "Scissors cut Paper"),
            new Outcome(Choices.Paper, Choices.Rock, "Paper covers Rock")
        };

        foreach (var outcome in outcomes)
        {
            if (outcome.Winner == _playerList[0].Choice && outcome.Loser == _playerList[1].Choice)
            {
                Console.WriteLine(outcome.Reason);
                Console.WriteLine($"{_playerList[0].Name} wins!");
                return false;
            } 
            if (outcome.Winner == _playerList[1].Choice && outcome.Loser == _playerList[0].Choice)
            {
                Console.WriteLine(outcome.Reason);
                Console.WriteLine($"{_playerList[1].Name} wins!");
                return false;
            }
        }

        return false;
    }
}