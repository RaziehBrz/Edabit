internal class Program
{
    private static void Main(string[] args)
    {
        var result = CountVowles("apple");
        Console.WriteLine(result);

    }
    static int CountVowles(string str)
    {
        int count = 0;
        foreach (var item in str)
        {
            if (item == 'a' ||
                item == 'e' ||
                item == 'i' ||
                item == 'u' ||
                item == 'o')
            {
                count++;
            }
        }
        return count;
    }
}