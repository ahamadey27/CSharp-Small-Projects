Console.WriteLine("Hello, World!");
Console.WriteLine("Press any key to progress or 'a' or 'b' when prompted");
Console.ReadKey();

Console.WriteLine("You are walking through a forest and you see a very strange dude");
Console.ReadKey();

Console.WriteLine("He says, \"Bro, you gotta choose path A or Path B\"");
var path = Console.ReadKey().Key;

if (path == ConsoleKey.A)
{
    Console.WriteLine("You go down path A and there are a ton of rabbits just hanging out looking at you..you feel uneasy");
    Console.ReadKey();
    Console.WriteLine("You see another guy who's chilling even harder");
    Console.WriteLine("He asks, \"You gotta choose path A or B again\"");
    if (path == ConsoleKey.A)
    {
        Console.WriteLine("You get to the end of the path and you grab a pint at the bar");
        Console.ReadKey();
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
