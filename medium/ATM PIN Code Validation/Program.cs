class Program
{
    static void Main(string[] args)
    {
        var result = ValidationPIN("12/456");
        Console.WriteLine(result);
    }
    static bool ValidationPIN(string pin)
    {
        bool isDigit = false;
        foreach (var x in pin)
        {
            if (char.IsDigit(x)) isDigit = true;
            else
            {
                isDigit = false;
                break;
            }
        }
        if ((pin.Length == 4 || pin.Length == 6) && isDigit)
        {
            return true;
        }
        return false;
    }
}