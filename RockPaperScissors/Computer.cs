namespace RockPaperScissors;

public class Computer() : Player("Computer")
{
    public override void Choose()
    {
        Choice = "Rock";
    }
}