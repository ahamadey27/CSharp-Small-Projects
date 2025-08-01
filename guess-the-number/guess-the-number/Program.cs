class Program
{

    //Initialize secret number to zero
    int secretNumber = 0;

    static void Main(string[] args)
    {
        Program program = new Program(); //Create reference instance for our Program class
        Random random = new Random(); //initialize instance of a random class
        program.secretNumber = random.Next(1, 10);


    }
}