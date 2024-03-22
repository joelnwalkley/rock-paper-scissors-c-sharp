namespace RockPaperScissors;

/// <summary>
/// A struct of possible outcomes in the game.
/// </summary>
/// <param name="winner"><see cref="Choice"/> that would win in this outcome.</param>
/// <param name="loser"><see cref="Choice"/> that would lose in this outcome.</param>
/// <param name="reason">Text to display why the outcome is the way it is.</param>
public readonly struct Outcome(Choice winner, Choice loser, string reason)
{
    public Choice Winner { get; } = winner;
    public Choice Loser { get; } = loser;
    public string Reason { get; } = reason;
}