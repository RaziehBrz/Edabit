class Program
{
    static void Main(string[] args)
    {
    }
    static int[] CountPosSumNeg(double[] arr)
    {
        return new int[] { arr.Count(x => x > 0), (int)arr.Where(x => x <= 0).Sum() };
    }
}