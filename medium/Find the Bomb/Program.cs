class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Bomb("bOmb"));

    }
    static string Bomb(string str)
    {
        return str.ToLower().Contains("bomb") ? "Duck!!!" : "There is no bomb, relax.";
    }

}