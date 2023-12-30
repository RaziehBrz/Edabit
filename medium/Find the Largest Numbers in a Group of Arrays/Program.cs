internal class Program
{
    private static void Main(string[] args)
    {

    }
    static double[] FindLargest(double[][] values)
    {
        var myList = new List<double>();
        foreach (var item in values)
        {
            myList.Add(item.Max());
        }
        return myList.ToArray();
    }
}