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
    }

    public void Run()
    {
        foreach (var player in _playerList)
        {
            player.SetName();
            player.Choose();
        }
    }
}