namespace RockPaperScissors;

public abstract class Player()
{

    public string? Name { get; protected set; }
    public Choice Choice { get; protected set; }

    public abstract void Choose();
    
    public abstract void SetName();

    public void StateChoice()
    {
        Console.WriteLine($"{Name} chose {Choice}");   
    }
}