namespace RockPaperScissors;

public class Computer() : Player()
{
    public override void Choose()
    {
        var random = new Random();
        var choice = random.Next(0, 3);
        Choice = Enum.GetName(typeof(Choices), choice);
    }

    public override void SetName()
    {
       Name = "Computer";
    }
}