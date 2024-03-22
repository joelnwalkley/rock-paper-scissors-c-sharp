namespace RockPaperScissors;

/// <summary>
/// Engine that runs the bus.
/// </summary>
public class GamerRunner
{
    private readonly List<Player> _playerList = [];
    private readonly List<Outcome> _outcomes;

    /// <summary>
    /// Default Constructor.
    /// </summary>
    public GamerRunner()
    {
        // Setup readonly variables

        var computerPlayer = new Computer();
        var humanPlayer = new Human();
        
        _playerList.Add(computerPlayer);
        _playerList.Add(humanPlayer);
        
        foreach (var player in _playerList)
        {
            player.SetName();
        }

        _outcomes = new List<Outcome>
        {
            new (Choice.Rock, Choice.Scissors, "Rock crushes Scissors"),
            new (Choice.Scissors, Choice.Paper, "Scissors cut Paper"),
            new (Choice.Paper, Choice.Rock, "Paper covers Rock")
        };
    }

    /// <summary>
    /// Run the game.
    /// </summary>
    public void Run()
    {
        var continueGame = true;
        while (continueGame)
        {
            Play();
            var isTie = Judge();

            while (isTie)
            {
                Play();

                isTie = Judge();
            }
            Console.Write("Play again? (Y/n): ");
            continueGame = ReplayCheck();
        }
        Console.WriteLine("Game Over");
    }

    /// <summary>
    /// Recursive method to check if user wants to continue.
    /// </summary>
    /// <returns>Bool value on whether or not to break the loop.</returns>
    private bool ReplayCheck()
    {
        var playAgain = Console.ReadKey().Key;
        switch (playAgain)
        {
            case ConsoleKey.Y:
                Console.WriteLine(); // formatting
                return true;
            case ConsoleKey.Enter:
                return true;
            case ConsoleKey.N: // explicitly stop
                Console.WriteLine(); // formatting
                return false;
            default: // any other key
                return ReplayCheck();
        }
    }

    /// <summary>
    /// Repeated action of having the players execute <see cref="Player.Choose()"/>. reduced to a private method to keep code DRY.
    /// </summary>
    private void Play()
    {
        foreach (var player in _playerList)
        {
            player.Choose();
        }
    }

    /// <summary>
    /// Determine who the winner is or declare a tie.
    /// </summary>
    /// <returns>True if a tie. False otherwise.</returns>
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

        foreach (var outcome in _outcomes)
        {
            if (outcome.Winner == _playerList[0].Choice && outcome.Loser == _playerList[1].Choice)
            {
                Console.WriteLine(outcome.Reason);
                Console.WriteLine($"{_playerList[0].Name} wins!");
                return false; // If we're done, we can leave the loop.
            }

            if (outcome.Winner != _playerList[1].Choice || outcome.Loser != _playerList[0].Choice) continue;
            Console.WriteLine(outcome.Reason);
            Console.WriteLine($"{_playerList[1].Name} wins!");
            return false;
        }

        return false;
    }
}