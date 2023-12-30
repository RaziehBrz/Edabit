internal class Program
{
    private static void Main(string[] args)
    {
        var result = ReverseCase("raXiJMN");
        Console.WriteLine(result);
    }
    static string ReverseCase(string str)
    {
        var result = "";
        foreach (var item in str)
        {
            if (char.IsUpper(item)) result += char.ToLower(item);
            else if (char.IsLower(item)) result += char.ToUpper(item);
            else result += item;
        }
        return result;
    }


}