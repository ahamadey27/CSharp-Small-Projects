class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rock paper scissors game");
        Console.WriteLine("Choose 1 for rock - 2 for paper - 3 for scissors");
        int playerMove = Convert.ToInt32(Console.ReadLine());

        Random random = new Random();

        int computerMove = random.Next(1, 4);

        string playerMoveString = "";

        switch (playerMove)
        {
            case 1: playerMoveString = "Rock"; break;
            case 2: playerMoveString = "Paper"; break;
            case 3: playerMoveString = "Scissors"; break;
            default: Console.WriteLine("Wrong choice"); break;
        }

        string computerMoveString = "";

        switch (computerMove)
        {
            case 1: computerMoveString = "Rock"; break;
            case 2: computerMoveString = "Paper"; break;
            case 3: computerMoveString = "Scissors"; break;
            default: Console.WriteLine("Wrong choice"); break;
        }

        Console.WriteLine($"You choose {playerMoveString} and computer chose {computerMoveString}");

        if (playerMove == computerMove)
        {
            Console.WriteLine("It's a draw");
        }

        else if ((playerMove == 1 && computerMove == 3) || (playerMove == 2 && computerMove == 1) || playerMove == 3 && computerMove == 2)
        {
            Console.WriteLine("You win");
        }
        else
            Console.WriteLine("You lost");
    }
}