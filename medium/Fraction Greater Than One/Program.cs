class Program
{
    static void Main(string[] args)
    {
        var result = GreaterThanOne("10/10");
        Console.WriteLine(result);
    }
    static bool GreaterThanOne(string str)
    {
        return int.Parse(str.Split('/')[0]) > int.Parse(str.Split('/')[1]);
    }
}

