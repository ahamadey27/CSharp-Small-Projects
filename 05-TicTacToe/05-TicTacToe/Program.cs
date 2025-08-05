public class Program
{
    public static char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

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

    public static bool Play(int player, int input)
    {
        char playerCharacter = player == 1 ? 'X' : 'O';
        if (input < 1 || input > 9)
        {
            Console.WriteLine("Invalid position. Choose 1-9.");
            return false;
        }
        if (boardPositions[input - 1] == 'X' || boardPositions[input - 1] == 'O')
        {
            Console.WriteLine("Position already taken. Choose another.");
            return false;
        }
        boardPositions[input - 1] = playerCharacter;
        return true;
    }

    public static bool CheckWin()
    {
        int[,] winPatterns = new int[,]
        {
            {0,1,2}, {3,4,5}, {6,7,8}, // Horizontal
            {0,3,6}, {1,4,7}, {2,5,8}, // Vertical
            {0,4,8}, {2,4,6}           // Diagonal
        };

        for (int i = 0; i < winPatterns.GetLength(0); i++)
        {
            int a = winPatterns[i, 0], b = winPatterns[i, 1], c = winPatterns[i, 2];
            if (boardPositions[a] == boardPositions[b] && boardPositions[b] == boardPositions[c])
            {
                return true;
            }
        }
        return false;
    }

    public static bool IsDraw()
    {
        foreach (char pos in boardPositions)
        {
            if (pos != 'X' && pos != 'O')
                return false;
        }
        return true;
    }

    public static void Main(string[] args)
    {
        int currentPlayer = 1;
        bool gameEnded = false;

        while (!gameEnded)
        {
            Console.Clear();
            DrawBoard();
            Console.WriteLine($"Player {currentPlayer} ({(currentPlayer == 1 ? 'X' : 'O')}), enter your move (1-9):");
            string inputStr = Console.ReadLine();
            int input;
            if (!int.TryParse(inputStr, out input))
            {
                Console.WriteLine("Invalid input. Press Enter to continue.");
                Console.ReadLine();
                continue;
            }

            if (!Play(currentPlayer, input))
            {
                Console.WriteLine("Press Enter to continue.");
                Console.ReadLine();
                continue;
            }

            if (CheckWin())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine($"Player {currentPlayer} wins!");
                gameEnded = true;
            }
            else if (IsDraw())
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("It's a draw!");
                gameEnded = true;
            }
            else
            {
                currentPlayer = currentPlayer == 1 ? 2 : 1;
            }
        }
        Console.WriteLine("Game over. Press Enter to exit.");
        Console.ReadLine();
    }
}






