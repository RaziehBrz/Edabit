internal class Program
{
    private static void Main(string[] args)
    {
        var result = ArrayOfMutiples(7, 5);
        foreach (var item in result)
        {
            Console.WriteLine(item);


        }
    }
    static int[] ArrayOfMutiples(int num, int length)
    {
        var result = new int[length];
        var temp = num;
        for (int i = 0; i < length; i++)
        {
            num = temp;
            num *= (i + 1);
            result[i] = num;
        }
        return result;
    }
}