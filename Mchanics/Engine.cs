class Engine
{
    public string name = "Engine";
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOGS]");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"1)Engine Details\n {name}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success add main details in engine!");
        Console.ResetColor();
    }
}