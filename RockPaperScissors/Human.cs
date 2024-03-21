namespace RockPaperScissors;

// class Human extends Player
public class Human() : Player()
{
    public override void Choose()
    {
        while (true)
        {
            Console.Write("Enter your choice (Rock, Paper, or Scissors): ");
            var input = Console.ReadLine();
            if (input is "Rock" or "Paper" or "Scissors")
            {
                Choice = input;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
                continue;
            }

            break;
        }
    }

    public override void SetName()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();
    }
}