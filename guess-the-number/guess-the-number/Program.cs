class Program
{

    //Initialize secret number to zero
    int secretNumber = 0;

    void Guess()
    {
        int guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You guessed {guess}");
        if (guess < secretNumber)
        {
            Console.WriteLine($"No, the number is higher than {guess}. Guess again.");
            Guess();
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine($"No, the number is lower than {guess}. Guess again.");
            Guess();

        }
        else
        {
            Win(guess);
        }
    }

    void Win(int guess)
    {

        Console.WriteLine($"You guessed the correct number of {guess}");
    }

    static void Main(string[] args)
    {
        Program program = new Program(); //Create reference instance for our Program class
        Random random = new Random(); //initialize instance of a random class
        program.secretNumber = random.Next(1, 10);

        Console.WriteLine("Guess the number between 1 and 10");
        program.Guess();






    }
}