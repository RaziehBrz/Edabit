class Program
{
    static void Main(string[] args)
    {

    }
    static int CountOne(int i)
    {
        string result = "";
        do
        {
            result += (i % 2).ToString();
            i /= 2;
        } while (i != 0);
        return result.Count(x => x == '1');
    }
}