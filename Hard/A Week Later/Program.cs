class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(WeekAfter("21/12/2023"));

    }
    static string WeekAfter(string date)
    {
        var x = date.Split('/');
        var day = x[0];
        if (day.StartsWith("0"))
        {
            day = (int.Parse(day) + 7).ToString();
        }
        else day = (int.Parse(day) + 7).ToString();

        return day + date.Substring(2);
    }
}