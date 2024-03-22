namespace RockPaperScissors;

// class Human extends Player
/// <inheritdoc cref="Player"/>
/// <remarks>User Controlled Human Player</remarks>
public class Human() : Player()
{
    /// <inheritdoc cref="Player.Choose()"/>
    /// <remarks>User chooses for human.</remarks>
    public override void Choose()
    {
        while (true)
        {
            Console.Write("Enter your choice (Rock, Paper, or Scissors): ");
            var input = Console.ReadLine()?.ToLower(); // so user doesn't need exact casing.
            if (input is "rock" or "paper" or "scissors")
            {
                Choice = Enum.Parse<Choice>(input, true); // ignoreCase so the change doesn't break.
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            break;
        }
    }

    /// <inheritdoc cref="Player.SetName()"/>
    /// <remarks>User set's name for human.</remarks>
    public override void SetName()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();
    }
}