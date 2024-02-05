class Progarm
{
    static void Main(string[] args)
    {
    }
    static int[] IndexOfCapitals(string str)
    {
        var listOfIndex = new List<int>();
        foreach (var c in str)
        {
            if (char.IsUpper(c)) listOfIndex.Add(str.IndexOf(c));
        }
        return listOfIndex.ToArray();
    }
}