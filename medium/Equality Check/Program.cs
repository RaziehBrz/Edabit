internal class Program
{
    private static void Main(string[] args)
    {
        var result2 = CheckEquality(false, false);
    }
    static bool CheckEquality(object a, object b)
    {
        var x = a.GetType();
        var y = b.GetType();
        if (x == y)
        {
            var result = a.ToString() == b.ToString();
            return result;
        }
        else return false;
    }
}