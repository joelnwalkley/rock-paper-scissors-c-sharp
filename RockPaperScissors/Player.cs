namespace RockPaperScissors;

public abstract class Player()
{

    public string? Name { get; protected set; }
    public string? Choice { get; protected set; }

    public abstract void Choose();
    
    public abstract void SetName();
}