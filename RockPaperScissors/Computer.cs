namespace RockPaperScissors;

public class Computer() : Player()
{
    public override void Choose()
    {
        Choice = "Rock";
    }

    public override void SetName()
    {
       Name = "Computer";
    }
}