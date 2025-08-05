public class Program
{
    public static char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
    public char playerCharacter = ' ';

    public static void DrawBoard()
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
    }
    public static void Main(string[] args)
    {
        DrawBoard();
        Console.ReadLine();
    }

}






