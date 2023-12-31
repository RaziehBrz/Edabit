class Program
{
    static void Main(string[] args)
    {
    }
    public static string FindNemo(string sentence)
    {
        var myArray = new string[] { };
        myArray = sentence.Split(' ');
        if (myArray.Contains("Nemo"))
        {
            var index = Array.FindIndex(myArray, x => x == "Nemo") + 1;
            return $"I found Nemo at {index}!";
        }
        return "I can't find Nemo :(";
    }
}