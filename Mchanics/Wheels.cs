class Wheels
{
    public string name = "Wheels";
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOGS]");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"2)Wheels\n {name}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success add 4 wheels!");
        Console.ResetColor();
    }
}