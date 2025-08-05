public class Program
{
    public static char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public char playerCharacter = ' ';

    public void DrawBoard()
    {
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardPositions[0], boardPositions[1], boardPositions[2]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardPositions[3], boardPositions[4], boardPositions[5]);
        Console.WriteLine("_____|_____|_____");
        Console.WriteLine("     |     |     ");
        Console.WriteLine("  {0}  |  {1}  |  {2}  ", boardPositions[6], boardPositions[7], boardPositions[8]);
        Console.WriteLine("     |     |     ");
    }

    public void Play(int player, int input)
    {
        if (player == 1)
        {
            playerCharacter = 'X';
        }
        else if (player == 2)
        {
            playerCharacter = 'O';
        }

        switch (input)
        {
            case 1:
                boardPositions[0] = playerCharacter; break;
            case 2:
                boardPositions[1] = playerCharacter; break;
            case 3:
                boardPositions[2] = playerCharacter; break;
            case 4:
                boardPositions[3] = playerCharacter; break;
            case 5:
                boardPositions[4] = playerCharacter; break;
            case 6:
                boardPositions[5] = playerCharacter; break;
            case 7:
                boardPositions[6] = playerCharacter; break;
            case 8:
                boardPositions[7] = playerCharacter; break;
            case 9:
                boardPositions[8] = playerCharacter; break;
        }
    }



    public static void Main(string[] args)
    {
        Program program = new Program();

        program.Play(1, 5);
        program.DrawBoard();
        Console.ReadLine();
    }

}






