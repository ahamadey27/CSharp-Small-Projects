class Program
{
    static void Main(string[] args)
    {
        int randomDiceRoll = 0;

        Console.WriteLine("Roll the dice!");
        Console.WriteLine("\nPress any key to roll the dice and keep going until you roll what the computer has generated");

        int diceRollComputer = 0;
        Random randomComp = new Random();
        diceRollComputer = randomComp.Next(1, 7); //Computers random number

        while (randomDiceRoll != diceRollComputer)
        {
            ConsoleKey keyPressed = Console.ReadKey(true).Key; //Add true as argument to avoid character being added to next string
            Random random = new Random(); //random initialization 
            randomDiceRoll = random.Next(1, 7); //through numbers 11 and 6...7 will be excluded

            Console.WriteLine($"{randomDiceRoll} is not it!");

            keyPressed = Console.ReadKey(true).Key;

        }

        Console.WriteLine($"You rolled {randomDiceRoll} which is matches the computer's roll of {diceRollComputer}");



    }
}
