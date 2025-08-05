public class Program
{
    public static char[] boardPositions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

    public static void DrawBoard()
    {

        //Row 1
        Console.WriteLine("  -------------------");
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  | {0} | {1} | {2} |", boardPositions[0], boardPositions[1], boardPositions[2]);
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  -------------------");
        //Row 2
        Console.WriteLine("  -------------------");
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  | {0} | {1} | {2} |", boardPositions[3], boardPositions[4], boardPositions[5]);
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  -------------------");
        //Row 3
        Console.WriteLine("  -------------------");
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  | {0} | {1} | {2} |", boardPositions[6], boardPositions[7], boardPositions[8]);
        Console.WriteLine("  |     |     |     |");
        Console.WriteLine("  -------------------");
    }
    public static void Main(string[] args)
    {
        DrawBoard();
        Console.ReadLine();
    }

}






