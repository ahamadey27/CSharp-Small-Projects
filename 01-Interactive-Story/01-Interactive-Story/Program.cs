Console.WriteLine("Hello, World!");
Console.WriteLine("Press any key to progress or 'a' or 'b' when prompted");
Console.ReadKey(true);

Console.WriteLine("You are walking through a forest and you see a very strange dude");
Console.ReadKey(true);

Console.WriteLine("He says, \"Bro, you gotta choose path A or Path B\"");
var path = Console.ReadKey(true).Key;

if (path == ConsoleKey.A)
{
    Console.WriteLine("You go down path A and there are a ton of rabbits just hanging out looking at you..you feel uneasy");
    Console.ReadKey(true);
    Console.WriteLine("You see another guy who's chilling even harder");
    Console.WriteLine("He asks, \"You gotta choose path A or B again\"");

    var secondPath = Console.ReadKey(true).Key;

    if (secondPath == ConsoleKey.A)
    {
        Console.WriteLine("You get to the end of the path and you grab a pint at the bar");
        Console.ReadKey(true);
        return;
    }
    else
    {
        Console.WriteLine("There's no bar :(");
    }
}
else
{
    Console.WriteLine("There are no bunnies on this path and you continue walking quietly.");
    return;
}
