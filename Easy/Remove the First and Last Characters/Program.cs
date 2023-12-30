internal class Program
{
    private static void Main(string[] args)
    {
        var result = RemoveFirstLast("zahra");
        Console.WriteLine(result);
    }
    static string RemoveFirstLast(string str)
    {
        if (str.Length < 3) return str;
        else
        {

            var myList = str.ToList();
            var count = myList.Count;
            myList.Remove(myList[0]);
            myList.Remove(myList[count - 1]);
            str = myList.ToString();
            return str;
        }

    }
}