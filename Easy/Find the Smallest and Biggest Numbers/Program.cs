internal class Program
{
    private static void Main(string[] args)
    {
        double[] numbers = { };
        var result = FindMinMax(numbers);
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
    static double[] FindMinMax(double[] numbers)
    {
        if (numbers.Length == 0) throw new ArgumentException("The input array is empty.");
        var max = numbers[0];
        var min = numbers[0];
        foreach (var number in numbers)
        {
            if (number > max) max = number;
            if (number < min) min = number;
        }
        return new double[] { min, max };
    }
}