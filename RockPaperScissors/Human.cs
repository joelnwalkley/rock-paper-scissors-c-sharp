namespace RockPaperScissors;

// class Human extends Player
public class Human() : Player()
{
    public override void Choose()
    {
        Choice = "Paper";
        //     // Console.WriteLine("Enter your choice: ");
        //     Console.WriteLine("Enter your choice: ");
        //     // var input = Console.ReadLine();
        //     var input = Console.ReadLine();
        //     // if (input == "Rock" || input == "Paper" || input == "Scissors")
        //     if (input == "Rock" || input == "Paper" || input == "Scissors")
        //     {
        //         // Choice = input;
        //         Choice = input;
        //     }
        //     // else
        //     else
        //     {
        //         // Console.WriteLine("Invalid choice. Please try again.");
        //         Console.WriteLine("Invalid choice. Please try again.");
        //         // Choose();
        //         Choose();
        //     }
    }

    public override void SetName()
    {
        Console.Write("Enter your name: ");
        Name = Console.ReadLine();
    }
}