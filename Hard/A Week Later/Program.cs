class Program
{
    static void Main(string[] args)
    {

    }
    static string WeekAfter(string date)
    {
        return new DateTime(
        Convert.ToInt32(date.Split('/')[2]),
        Convert.ToInt32(date.Split('/')[1]),
        Convert.ToInt32(date.Split('/')[0]))
        .AddDays(7).Date.ToString("dd/MM/yyyy");
    }

}