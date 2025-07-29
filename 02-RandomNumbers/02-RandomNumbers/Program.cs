class Program
{
    static void Main(string[] args)
    {
        int randomDiceRoll = 0;
        Console.WriteLine("Roll the dice!");
        Console.WriteLine("\nPress any key to roll the dice");
        Console.ReadKey(true); //Add true as argument to avoid character being added to next string

        Random random = new Random(); //random initialization 
        randomDiceRoll = random.Next(1, 7); //through numbers 11 and 6...7 will be excluded

        Console.WriteLine($"Our random number is {randomDiceRoll}");


    }
}
