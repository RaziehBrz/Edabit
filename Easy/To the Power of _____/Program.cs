internal class Program
{
    private static void Main(string[] args)
    {
        var result = CalculateExponent(3, 3);
        Console.WriteLine(result);
    }
    static long CalculateExponent(long number, long exponent)
    {
        long result = 0;
        var temp = number;
        if (exponent == 0) result = 1;
        else
        {
            for (int i = 0; i < exponent - 1; i++)
            {
                number *= temp;
            }
            result = number;
        }
        return result;
    }
}