class Body
{
    public string name = "Body";
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOGS]");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"3)Body\n {name}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success add body!");
        Console.ResetColor();
    }
}