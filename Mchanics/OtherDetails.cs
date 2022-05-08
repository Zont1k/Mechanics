class OtherDetails
{
    public string name = "OtherDetails";
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOGS]");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"4)Other Details\n {name}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Success add other details!");
        Console.ResetColor();
    }
}