class Progarm
{
    static void Main(string[] args)
    {
        Console.WriteLine(GetMiddle("test"));

    }
    static string GetMiddle(string str)
    {
        return str.Length % 2 == 0 ? str[str.Length / 2 - 1] + str[str.Length / 2].ToString() : str[str.Length / 2].ToString();
    }
}