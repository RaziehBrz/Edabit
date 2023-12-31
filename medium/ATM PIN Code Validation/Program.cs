class Program
{
    static void Main(string[] args)
    {
        var result = ValidationPIN("12/456");
        Console.WriteLine(result);
    }
    static bool ValidationPIN(string pin)
    {
        return (pin.Length == 4 || pin.Length == 6) && pin.All(Char.IsDigit);
    }
}