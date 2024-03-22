namespace RockPaperScissors;

/// <inheritdoc cref="Player"/>
/// <remarks>Computer Controlled Player</remarks>
public class Computer() : Player()
{
    /// <inheritdoc cref="Player.Choose()"/>
    /// <remarks>Computer Randomized choice.</remarks>
    public override void Choose()
    {
        var random = new Random();
        var choice = random.Next(0, 3);
        Choice = (Choice)choice;
    }

    /// <inheritdoc cref="Player.SetName()"/>
    /// <remarks>Defaults to Computer in this class</remarks>
    public override void SetName()
    {
        Name = "Computer";
    }
}