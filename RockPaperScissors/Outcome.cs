namespace RockPaperScissors;

public struct Outcome(Choice winner, Choice loser, string reason)
{
    public Choice Winner { get; } = winner;
    public Choice Loser { get; } = loser;
    public string Reason { get; } = reason;
}