class Program
{
    static void Main(string[] args)
    {
    }
    static int CounterpartCharCode(char symbol)
    {
        return char.IsLower(symbol) ? char.ToUpper(symbol) : char.ToLower(symbol);
    }
}