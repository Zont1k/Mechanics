class Car
{
    public string name = "Car";
    public void Print()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("[LOGS]");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"CAR\n {name}");
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("The car is working!!");
        Console.ResetColor();
    }
}