namespace RockPaperScissors;

public struct Outcome(Choices winner, Choices loser, string reason)
{
    public Choices Winner { get; } = winner;
    public Choices Loser { get; } = loser;
    public string Reason { get; } = reason;
}