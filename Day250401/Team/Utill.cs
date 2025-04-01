namespace Day250401.Team;

public class Utill
{
    public static void PrintLine(string data, ConsoleColor color, int deley = 0)
    {
        foreach (char c in data)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(c);
            Thread.Sleep(deley);
            Console.ResetColor();
        }
    }
    public static void Print(string data, ConsoleColor color= ConsoleColor.Red, int deley = 100)
    {
        foreach (char c in data)
        {
            Console.ForegroundColor = color;
            Console.Write(c);
            Thread.Sleep(deley);
            Console.ResetColor();
        }
        Console.WriteLine();
    }
}