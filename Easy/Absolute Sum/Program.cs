
internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 2, -1, 4, 8, 10 };
        var result = getAbsSum(numbers);
        Console.WriteLine(result);
    }
    static int getAbsSum(int[] numbers)
    {
        int sum = 0;
        if (numbers.Length == 0) throw new ArgumentException("The input array is empty.");
        foreach (var number in numbers)
        {
            if (number >= 0) sum += number;
            else
            {
                var positiveNumber = number * (-1);
                sum += positiveNumber;
            }
        }
        return sum;
    }

}