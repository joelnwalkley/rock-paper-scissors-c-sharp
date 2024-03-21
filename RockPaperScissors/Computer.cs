namespace RockPaperScissors;

// Computer extends the abstract class Player
public class Computer(string name) : Player(name)
{
    public override void Choose()
    {
        Choice = "Rock";
    }
}