namespace RockPaperScissors;

/// <summary>
/// Participant of game.
/// </summary>
public abstract class Player()
{

    /// <summary>
    /// Name of Player.
    /// </summary>
    public string? Name { get; protected set; }

    /// <summary>
    /// Current choice of player.
    /// </summary>
    public Choice Choice { get; protected set; }

    /// <summary>
    /// Let player choose rock, paper, or scissors.
    /// </summary>
    public abstract void Choose();

    /// <summary>
    /// Set's player's name.
    /// </summary>
    public abstract void SetName();

    /// <summary>
    /// Prints choice made to console.
    /// </summary>
    public void StateChoice()
    {
        Console.WriteLine($"{Name} chose {Choice}");   
    }
}