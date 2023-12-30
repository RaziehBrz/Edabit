internal class Program
{
    private static void Main(string[] args)
    {
        var result = count_all("54erty");
        Console.WriteLine(result);
    }
    static string count_all(string txt)
    {
        int letters = 0;
        int digits = 0;

        foreach (var item in txt)
        {
            if (char.IsLetter(item)) letters++;
            else if (char.IsDigit(item)) digits++;
        }
        string result = $"{{ LETTERS = {letters}, DIGITS = {digits} }}";
        return result;
    }
}