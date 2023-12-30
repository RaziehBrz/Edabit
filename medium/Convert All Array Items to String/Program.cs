internal class Program
{
    private static void Main(string[] args)
    {
        var myArray = new object[] { 1, 2, "a", "b" };

        var result = ParseArray(myArray);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
    static string[] ParseArray(object[] arr)
    {
        /*var result = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].GetType().ToString() == "Int32") result.Add(arr[i].ToString());
            else result.Add(arr[i].ToString());
        }
        return result.ToArray();*/
        return arr.Select(x => x.ToString()).ToArray();
    }
}