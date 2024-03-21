namespace RockPaperScissors;

public abstract class Player(string name)
{
    public string Name { get; } = name;
    public string? Choice { get; protected set; }

    public abstract void Choose();
}